using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            public const int IsPartTime = 1;
        public const int IsFullTime = 2;
        public const int EmpRatePerHr = 20;

        static void Main(string[] args)
        {
            //Variables
            int empWage = 0;
            int empHr = 0;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IsPartTime:
                    empHr = 4;
                    break;

                case IsFullTime:
                    empHr = 8;
                    break;

                default:
                    empHr = 0;
                    break;
            }
            empWage = empHr * EmpRatePerHr;
            Console.WriteLine("Employee Wage = " + empWage);
        }
    }
}
