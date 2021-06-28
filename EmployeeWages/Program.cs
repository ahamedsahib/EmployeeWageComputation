using System;

namespace EmployeeWages
{
    class Program
    {
        public const int fullTime = 1;
        public const int partTime = 2;
        public const int wage_per_hour = 20;
        public const int working_day = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Computation Program");
            
            int working_hour_per_day = 0;
            int total_wage = 0;
            int fullday = 0;
            int halfday = 0;
            int absent = 0;

            for (int day = 1; day <= 20; day++)
            {

                Random random = new Random();
                int emp_Input = random.Next(0, 3);
                
                switch (emp_Input)
                {
                    case fullTime:
                        working_hour_per_day = 8;
                        fullday++;
                        break;
                    case partTime:
                        working_hour_per_day = 4;
                        halfday++;
                        break;
                    default:
                        working_hour_per_day = 0;
                        absent++;
                        break;

                }

                total_wage+= working_hour_per_day * wage_per_hour;
 
            }
            Console.WriteLine($"Employee woked in a month as\nFullTime: {fullday} \nParTime: {halfday}\nAbsent: {absent}");
            Console.WriteLine($"The Wages of Employee per month: {total_wage} ");

        }
    }
}
