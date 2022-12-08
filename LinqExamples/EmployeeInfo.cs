using System.ComponentModel.DataAnnotations;

namespace LinqExamples
{
    public class EmployeeInfo
    {
        public static IEnumerable<Employee> EmployeesWithSalaryGreaterThan100K(IEnumerable<Employee> employees)
        {
          var employeewithSalaryGreaterthan100K = employees.Where(x=>x.Salary > 100000).Select(a=>a);
           return employeewithSalaryGreaterthan100K;
        }

        public static double AverageConsultantSalaryInBrisbane(IEnumerable<Employee> employees)
        {
            var employeeBrisbaneAverageConsultSalary = employees.Where(x => x.City.ToLower() == "brisbane" && x.Level.ToLower() == "consultant").Select(b => b);
      
            return EmployeeInfoHelper.AverageSalary(employeeBrisbaneAverageConsultSalary);
            
        }
    }
}