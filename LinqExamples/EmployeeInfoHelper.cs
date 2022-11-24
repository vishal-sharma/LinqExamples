using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    internal static class EmployeeInfoHelper
    {
        // use this Extension method in your code to calculate average
        public static double AverageSalary(this IEnumerable<Employee> employees)
            => employees.Select(x => x.Salary).Average();
    }
}
