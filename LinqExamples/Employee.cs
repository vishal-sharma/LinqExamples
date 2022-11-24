using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    public class Employee
    {   
        public Employee(string firstName, string city, string level, double salary)
        {
            FirstName = firstName;
            City = city;
            Level = level;
            Salary = salary;
        }

        public string FirstName { get; set; }
        public string City { get; set; }
        public string Level { get; set; }
        public double Salary { get; set; }
    }

}
