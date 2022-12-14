namespace LinqExamples
{
    public class EmployeeInfo
    {
        public static IEnumerable<Employee> EmployeesWithSalaryGreaterThan100K(IEnumerable<Employee> employees)
        {
            return employees.Where(a => a.Salary > 100000);
        }

        public static double AverageConsultantSalaryInBrisbane(IEnumerable<Employee> employees)
        {
            return EmployeeInfoHelper.AverageSalary(employees.Where(a => a.City == "Brisbane" && a.Level == "Consultant"));
        }
    }
}