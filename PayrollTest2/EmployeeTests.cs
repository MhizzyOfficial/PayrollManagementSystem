public class EmployeeTests
{
    [Fact]
    public void CalculatePayroll_ShouldCalculateGrossPayCorrectly()
    {
        // Arrange
        var employee = new Employee(20, 30);
        employee.RegularHours = 40;
        employee.OvertimeHours = 10;

        // Act
        employee.CalculatePayroll();

        // Assert
        Assert.Equal(1300, employee.GrossPay);
    }

    [Fact]
    public void CalculatePayroll_ShouldCalculateNetPayCorrectly()
    {
        // Arrange
        var employee = new Employee(20, 30);
        employee.RegularHours = 40;
        employee.OvertimeHours = 10;

        // Act
        employee.CalculatePayroll();

        // Assert
        Assert.Equal(1080, employee.NetPay);
    }

    [Fact]
    public void CalculatePayroll_ShouldNotCalculatePayrollIfEmployeeIsNotActive()
    {
        // Arrange
        var employee = new Employee(20, 30);
        employee.RegularHours = 40;
        employee.OvertimeHours = 10;
        employee.IsActive = false;

        // Act
        employee.CalculatePayroll();

        // Assert
        Assert.Equal(0, employee.GrossPay);
        Assert.Equal(0, employee.NetPay);
    }
}
