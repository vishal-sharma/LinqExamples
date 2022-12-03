namespace LinqExamples
{
    public class EmployeeInfo
    {
        public static IEnumerable<Employee> EmployeesWithSalaryGreaterThan100K(IEnumerable<Employee> employees)
        {
            return employees.Where(emp => emp.Salary > 100000);
        }

        public static double AverageConsultantSalaryInBrisbane(IEnumerable<Employee> employees)
        {
            return EmployeeInfoHelper.AverageSalary(employees.Where(emp => emp.City == "Brisbane"));
        }
    }
}
