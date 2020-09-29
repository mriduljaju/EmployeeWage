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
		public const int NumOfWorkingDays = 2;
		static void Main(string[] args)
		{
			//Variables
			int empWage = 0;
			int empHr = 0;
			int TotalEmpWage = 0;

			//Computation
			for (int Day = 0; Day < NumOfWorkingDays; Day++)
			{
				Random random = new Random();
				int empCheck = random.next(0, 3);
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
				TotalEmpWage += empWage;
				Console.WriteLine("Employee Wage = " + empWage);
			}
			Console.WriteLine("Total Emp Wage = " + TotalEmpWage);
		}
    }
}
