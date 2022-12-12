namespace LinqExamples
{
    public class EmployeeInfo
    {
        // Filters employees for Salary > 100000
        public static IEnumerable<Employee> EmployeesWithSalaryGreaterThan100K(IEnumerable<Employee> employees)
        {
            return employees.Where(employee => employee.Salary > 100000);
        }

        // Filters employees for Level == "Consultant" && City == "Brisbane"
        // then calls AverageSalary() to find the average Salary of the filtered employees
        public static double AverageConsultantSalaryInBrisbane(IEnumerable<Employee> employees)
        {
            return employees.Where(employee => employee.Level == "Consultant" && employee.City == "Brisbane").AverageSalary();
        }
    }
}
