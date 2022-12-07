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
            var employeesInPerth = from emp in employees
                                   where emp.City == "Perth"
                                   select emp;
            var TotalSalariesInPerth = EmployeeInfoHelper.TotalSalary(employeesInPerth);

            return TotalSalariesInPerth;
        }

        public static double ConsultantSalaryRange(IEnumerable<Employee> employees)
        {
            var consultants = from emp in employees
                              where emp.Level == "Consultant"
                              select emp;
            var avgSalaryForConsultants = EmployeeInfoHelper.AverageSalary(consultants);
            
            return avgSalaryForConsultants;
        }
    }
}
