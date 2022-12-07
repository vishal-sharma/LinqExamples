using LinqExamples;

namespace LinqExxamplesTests
{
    public class EmployeeInfoTests
    {
        IEnumerable<Employee> employees = new Employee[8]
            {
                new Employee ( firstName: "Alex", city: "Brisbane", salary: 100000, level: "Consultant"),
                new Employee ( firstName: "Khoi", city: "Brisbane", salary: 120000, level: "Consultant"),
                new Employee ( firstName: "Sam",  city: "Brisbane", salary: 80000, level: "Analyst"),
                new Employee ( firstName: "Deepinder", city: "Melbourne", salary: 120000, level: "Consultant"),
                new Employee ( firstName: "Nicky", city: "Sydney", salary: 100000, level: "Analyst"),
                new Employee ( firstName: "Bernard", city: "Perth", salary: 55000, level: "Junior Developer"),
                new Employee ( firstName: "Sarah", city: "Perth", salary: 100000, level: "Analyst"),
                new Employee ( firstName: "John", city: "Perth", salary: 80000, level: "Developer")
            };

        [Fact]
        public void TestEmployeesWithSalaryGreaterThan100K()
        {
            var employeesWithSalaryGreaterThan100K = EmployeeInfo.EmployeesWithSalaryGreaterThan100K(employees);
            Assert.Equal(2, employeesWithSalaryGreaterThan100K.Count());
        }

        [Fact]
        public void TestAverageConsultantSalaryInBrisbane()
        {
            var averageConsultantSalaryInBrisbane = EmployeeInfo.AverageConsultantSalaryInBrisbane(employees);
            Assert.Equal(110000, averageConsultantSalaryInBrisbane);
        }

        [Fact]
        public void TestTotalSalaryInPerth()
        {
            var totalSalaryInPerth = EmployeeInfo.TotalSalariesInPerth(employees);
            Assert.Equal(235000, totalSalaryInPerth);
        }

        [Fact]
        public void TestAverageConsultantSalaryRangeIsBetween100Kand120K()
        {
            var averageConsultantSalaryRangeIsBetween100Kand120K = EmployeeInfo.ConsultantSalaryRange(employees);
            Assert.InRange(averageConsultantSalaryRangeIsBetween100Kand120K, 100000, 120000);
        }
    }
}