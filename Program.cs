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
		public const int MaxHrInAMonth = 10;

		static void Main(string[] args)
		{

			int TotalempHr = 0;
			int empHr = 0;
			int TotalWorkingDays = 0;
			while (TotalempHr <= MaxHrInAMonth && TotalWorkingDays <= NumOfWorkingDays)
			{
				TotalWorkingDays++;
				random random = new Random();
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
				TotalEmpHr += empHr;
				Console.WriteLine("Day # =" + TotalWorkingDays + "Emp hrs :" + empHr);
			}
			int TotalEmpWage = TotalempHr * EmpRatePerHr;
			Console.WriteLine("Total Emp Wage = " + TotalEmpWage);
		}
    }
}
