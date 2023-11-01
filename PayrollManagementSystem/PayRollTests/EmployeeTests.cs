using PayRollManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PayrollManagementSystem.PayRollTests
{
    public class EmployeeTests
    {
        [Fact]
        public void CalculatePayroll_ShouldCalculateGrossPayCorrectly()
        {
            // Arrange
            var employee = new Employee(20, 30);
            employee.RegularHours = 40;
            employee.OvertimeHours = 10;
            employee.IsActive = true;

            // Act
            employee.CalculatePayroll();

            // Assert
            Assert.Equal(1100, employee.GrossPay);
        }

        [Fact]
        public void CalculatePayroll_ShouldCalculateNetPayCorrectly()
        {
            // Arrange
            var employee = new Employee(20, 30);
            employee.RegularHours = 40;
            employee.OvertimeHours = 10;
            employee.IsActive = true;
            employee.MedicareDeduction = 0.02 * employee.GrossPay;
            employee.FoodDeduction = 0.03  * employee.GrossPay;
            employee.RentDeduction = 0.05 * employee.GrossPay;

            // Act
            employee.CalculatePayroll();
            // Assert
            Assert.Equal(990, employee.NetPay);
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
}
