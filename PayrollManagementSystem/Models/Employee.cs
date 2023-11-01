using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace PayRollManagementSystem.Models

{

    public class Employee

    {

        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime PayDate { get; set; }

        public double RegularHours { get; set; }

        public double OvertimeHours { get; set; }

        private double regularRate;

        private double overtimeRate;

        public double RegularRate

        {

            get { return regularRate; }

        }

        public double OvertimeRate

        {

            get { return overtimeRate; }

        }

        public double GrossPay { get;  set; }

        public double NetPay { get;  set; }

        public double MedicareDeduction { get;  set; }

        public double RentDeduction { get;  set; }

        public double FoodDeduction { get;  set; }

        public Employee(double regularRate, double overtimeRate)

        {

            this.regularRate = regularRate;

            this.overtimeRate = overtimeRate;

        }

        public void CalculatePayroll()

        {

            if (IsActive)
                NewMethod();
        }

        private void NewMethod()
        {
            GrossPay = (RegularHours * RegularRate) + (OvertimeHours * OvertimeRate);

            if (OvertimeHours == 0)

            {

                GrossPay = RegularHours * RegularRate;

            }

            MedicareDeduction = 0.02 * GrossPay;

            RentDeduction = 0.05 * GrossPay;

            FoodDeduction = 0.03 * GrossPay;

            NetPay = GrossPay - (MedicareDeduction + RentDeduction + FoodDeduction);

        }
    }

}

