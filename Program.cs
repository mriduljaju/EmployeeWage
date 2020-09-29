using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constants
            int IsFullTime = 2;
            int IsPartTime = 1;
            int EmpRatePerHour = 20;
            //Variables
            int empWage = 0;
            int empHr = 0;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 3);
            if (empCheck == IsPartTime)
            {

                empHr = 4;
            }
            else if (empCheck == IsFullTime)
            {

                empHr = 8;
            }
            else
            {
                empHr = 0;
            }
            empWage = empHr * EmpRatePerHour;
            Console.WriteLine("Employee Wage = " + empWage);
        }
    }
}
