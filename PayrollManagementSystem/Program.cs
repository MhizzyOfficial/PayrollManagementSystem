using PayRollManagementSystem.Models;

internal class Program

{
    private static void Main(string[] args)
    {
        PayrollManager payrollManager = new PayrollManager();

        while (true)
        {
            Console.Clear();
            Console.Title = "Payroll System Management";
            Console.WriteLine("Welcome to Stephen Payroll System");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Kindly enter employee details:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            if (name.ToLower() == "exit")
                break;

            Console.Write("If Employee is Active, kindly write true (true/false): ");
            bool isActive = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Start Date (yyyy/mm/dd): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());

            Console.Write("End Date (yyyy/mm/dd): ");
            DateTime endDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Pay Date (yyyy/mm/dd): ");
            DateTime payDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Regular Hours: ");
            double regularHours = Convert.ToDouble(Console.ReadLine());

            Console.Write("Overtime Hours: ");
            double overtimeHours = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Regular Rate: ");
            //double regularRate = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Overtime Rate: ");
            //double overtimeRate = Convert.ToDouble(Console.ReadLine());

            Employee newEmployee = new Employee(1500, 200)
            {
                Name = name,
                IsActive = isActive,
                StartDate = startDate,
                EndDate = endDate,
                PayDate = payDate,
                RegularHours = regularHours,
                OvertimeHours = overtimeHours
            };

            payrollManager.AddEmployee(newEmployee);
        }
        payrollManager.PrintEmployeeInfo();
    }
}