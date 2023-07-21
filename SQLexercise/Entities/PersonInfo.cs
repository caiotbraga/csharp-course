using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLexercise.Entities
{
    internal class PersonInfo 
    {
        public string name { get; set; }
        public string email { get; set; }
        public double salary { get; set; }

        public PersonInfo(string name, string email, double salary)
        {
            this.name = name;
            this.email = email;
            this.salary = salary;
        }
    }
}
