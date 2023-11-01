public class PayrollManagerTests
{
    [Fact]
    public void PrintEmployeeInfo_ShouldPrintEmployeeInfoCorrectly()
    {
        // Arrange
        var payrollManager = new PayrollManager();

        var employee1 = new Employee(20, 30);
        employee1.Name = " ";
        employee1.IsActive = true;
        employee1.StartDate = new DateTime(2023, 10, 31);
        employee1.EndDate = new DateTime(2024, 10, 31);
        employee1.PayDate = new DateTime(2023, 11, 15);
        employee1.RegularHours = 40;
        employee1.OvertimeHours = 10;

        payrollManager.AddEmployee(employee1);

        var expectedTable = new ConsoleTable("Name", "Active", "Start Date", "End Date", "Pay Date", "Regular Hours", "Overtime Hours");
        expectedTable.AddRow("John Doe", true, new DateTime(2023, 10, 31), new DateTime(2024, 10, 31), new DateTime(2023, 11, 15), 40, 10);

        // Act
        payrollManager.PrintEmployeeInfo();

        // Assert
        var actualTable = Console.Out.ToString();
        Assert.Contains(expectedTable.ToString(), actualTable);
    }
}
