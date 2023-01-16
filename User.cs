using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDefining_Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        // навигационное свойство
        public Company? Company { get; set; }
    }

    public class Company
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
    public class Country
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
