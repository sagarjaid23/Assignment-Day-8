using System;

namespace UC7
{
    internal class Program
    {
        public const int parttime = 1;
        public const int fulltime = 2;
        public const int EMP_WAGE_PER_HR = 20;
        public const int WORKING_DAYS = 20;
        private static int empHr;
        public static int totalEmpHrs = 0;
        public static int empHrs = 0;
        public static int totalWorkingDays=0;

        public static void ComputeEmployerWage()
        {
            int monthlySalary = 0;
            NewMethod();
            monthlySalary = EMP_WAGE_PER_HR * totalEmpHrs;
            Console.WriteLine("Total Salary of Employee in Month is:" + monthlySalary);
        }

        private static void NewMethod()
        {
            while (totalWorkingDays < ProgramHelpers.Max_Hrs_In_Month && totalWorkingDays < WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int rand = (random.Next() % 3) + 1;
                empHr = GetworkingHour(rand);
                totalEmpHrs = totalEmpHrs + empHr;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problem");
            ComputeEmployerWage();
        }
    }
}
