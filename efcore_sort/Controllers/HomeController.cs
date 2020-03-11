using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using efcore_sort.Models;

namespace efcore_sort.Controllers
{
    public class HomeController : Controller
    {
        UsersContext db;

        public HomeController(UsersContext context)
        {
            db = context;

            Company oracle = new Company { Name = "Oracle" };
            Company google = new Company { Name = "Google" };
            Company microsoft = new Company { Name = "Microsoft" };
            Company apple = new Company { Name = "Apple" };

            User user1 = new User { Name = "Олег Васильев", Company = oracle, Age = 26 };
            User user2 = new User { Name = "Александр Овсов", Company = oracle, Age = 24 };
            User user3 = new User { Name = "Алексей Петров", Company = microsoft, Age = 25 };
            User user4 = new User { Name = "Иван Иванов", Company = microsoft, Age = 26 };
            User user5 = new User { Name = "Петр Андреев", Company = microsoft, Age = 23 };
            User user6 = new User { Name = "Василий Иванов", Company = google, Age = 23 };
            User user7 = new User { Name = "Олег Кузнецов", Company = google, Age = 25 };
            User user8 = new User { Name = "Андрей Петров", Company = apple, Age = 24 };

            db.Companies.AddRange(oracle, google, microsoft, apple);
            db.Users.AddRange(user1, user2, user3, user4, user5, user6, user7, user8);
            db.SaveChanges();
        }

        public IActionResult Index()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
