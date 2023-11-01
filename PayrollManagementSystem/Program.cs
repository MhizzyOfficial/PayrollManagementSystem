
using PayRollManagementSystem.Models;

PayrollManager payrollManager = new PayrollManager();

while (true)
{
    Console.Title = "Payroll System";
    Console.WriteLine("Kindly enter employee details (or type 'exit' to print output):");
    Console.WriteLine();

    Console.Write("Name: ");
    string name = Console.ReadLine();

    bool shouldBreak = name.ToLower() == "exit";
    if (shouldBreak)
    {
        break;
    }

    Console.Write("If Employee is Active, kindly write true (true/false): ");
    bool isActive = Convert.ToBoolean(Console.ReadLine());

    Console.Write("Start Date (yyyy/mm/dd): ");
    DateTime startDate;
    try
    {
        startDate = DateTime.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid start date format.");
        continue;
    }

    Console.Write("End Date (yyyy/mm/dd): ");
    DateTime endDate;
    try
    {
        endDate = DateTime.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid end date format.");
        continue;
    }

    Console.Write("Pay Date (yyyy/mm/dd): ");
    DateTime payDate;
    try
    {
        payDate = DateTime.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid pay date format.");
        continue;
    }

    Console.Write("Regular Hours: ");
    double regularHours = Convert.ToDouble(Console.ReadLine());

    Console.Write("Overtime Hours: ");
    double overtimeHours = Convert.ToDouble(Console.ReadLine());

    Employee newEmployee = new Employee(1500, 200);
    newEmployee.Name = name;
    newEmployee.IsActive = isActive;
    newEmployee.StartDate = startDate;
    newEmployee.EndDate = endDate;
    newEmployee.PayDate = payDate;
    newEmployee.RegularHours = regularHours;
    newEmployee.OvertimeHours = overtimeHours;

    payrollManager.AddEmployee(newEmployee);
}

payrollManager.PrintEmployeeInfo();
Console.Write(Console.ReadLine());
