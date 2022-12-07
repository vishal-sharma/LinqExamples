using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    internal static class EmployeeInfoHelper
    {
        // Extension method to calculate average salary
        public static double AverageSalary(this IEnumerable<Employee> employees)
            => employees.Select(x => x.Salary).Average();
        
        // Extension method to calculate total salary
        public static double TotalSalary(this IEnumerable<Employee> employees)
            => employees.Select(x => x.Salary).Sum();
    }
}
