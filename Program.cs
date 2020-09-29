using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constants
            int IsFullTime = 1;
            int EmpRatePerHour = 20;
            //Variables
            int empWage = 0;
            int empHr = 0;

            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IsFullTime)
            {
                Console.WriteLine("Employee is Present.");
                empHr = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent!");
                empHr = 0;
            }
            empWage = empHr * EmpRatePerHour;
            Console.WriteLine("Employee Wage = " + empWage);
        }
    }
}
