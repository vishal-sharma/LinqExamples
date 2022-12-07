namespace LinqExamples
{
    public class EmployeeInfo
    {
        public static IEnumerable<Employee> EmployeesWithSalaryGreaterThan100K(IEnumerable<Employee> employees)
        {
            employees = from emp in employees
                        where emp.Salary > 100000
                        select emp;
            return employees;
        }

        public static double AverageConsultantSalaryInBrisbane(IEnumerable<Employee> employees)
        {
            var employeesInBrisbane = from emp in employees
                                      where emp.City == "Brisbane" && emp.Level == "Consultant"
                                      select emp;
            var avgBrisbaneConsultantSalary = EmployeeInfoHelper.AverageSalary(employeesInBrisbane);

            return avgBrisbaneConsultantSalary;
        }
        public static double TotalSalariesInPerth(IEnumerable<Employee> employees)
        {
            return 0;
        }

        public static double ConsultantSalaryRange(IEnumerable<Employee> employees)
        {
            return 0;
        }
    }
}
