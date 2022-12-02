using LinqExamples;

namespace LinqExxamplesTests
{
    public class EmployeeInfoTests
    {
        IEnumerable<Employee> employees = new Employee[5]
            {
                new Employee ( firstName: "Alex", city: "Brisbane", salary: 100000, level: "Consultant"),
                new Employee ( firstName: "Khoi", city: "Brisbane", salary: 120000, level: "Consultant"),
                new Employee ( firstName: "Sam",  city: "Brisbane", salary: 80000, level: "Analyst"),
                new Employee ( firstName: "Deepinder", city: "Melbourne", salary: 120000, level: "Consultant"),
                new Employee ( firstName: "Nicky", city: "Sydney", salary: 100000, level: "Analyst")
            };

        [Fact]
        public void TestEmployeesWithSalaryGreaterThan100K()
        {
            var employeesWithSalaryGreaterThan100K = EmployeeInfo.EmployeesWithSalaryGreaterThan100K(employees);
            Assert.Equal(employeesWithSalaryGreaterThan100K.Count(), 2);
        }

        [Fact]
        public void TestAverageConsultantSalaryInBrisbane()
        {
            var averageConsultantSalaryInBrisbane = EmployeeInfo.AverageConsultantSalaryInBrisbane(employees);
            Assert.Equal(averageConsultantSalaryInBrisbane, 100000);
        }
    }
}
