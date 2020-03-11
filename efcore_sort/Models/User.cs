using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace efcore_sort.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int CompanyId { get; set; }

        public Company Company { get; set; }
    }
}
