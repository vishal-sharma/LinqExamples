namespace LinqExamples
{
    public class EmployeeInfo
    {
        public static IEnumerable<Employee> EmployeesWithSalaryGreaterThan100K(IEnumerable<Employee> employees)
        {
            // Filter employees by salary > 100,000
            return employees.Where(employee => employee.Salary > 100000);
        }

        public static double AverageConsultantSalaryInBrisbane(IEnumerable<Employee> employees)
        {
            // Average Salary of employees filtered by location and level to be Brisbane and Consultant respectively.
            return employees.Where(employee => employee.City == "Brisbane" && employee.Level == "Consultant").AverageSalary();
        }
    }
}