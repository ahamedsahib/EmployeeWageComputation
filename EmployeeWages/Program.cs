using System;

namespace EmployeeWages
{
    class Program
    {
        public const int fullTime = 1;
        public const int partTime = 2;
        public const int wage_per_hour = 20;
        public const int working_day = 20;
        public const int max_working_hour = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Computation Program");
            
            int working_hour = 0;
            int total_hour = 0;
            int working_day = 0;
            int total_wage = 0;
            int fullday = 0;
            int halfday = 0;
            int absent = 0;

            while(working_hour<=max_working_hour && working_day<=20)
            {

                Random random = new Random();
                int emp_Input = random.Next(0, 3);
                
                switch (emp_Input)
                {
                    case fullTime:
                        working_hour = 8;
                        fullday++;
                        break;
                    case partTime:
                        working_hour = 4;
                        halfday++;
                        break;
                    default:
                        working_hour = 0;
                        absent++;
                        break;

                }
                working_day++;
                total_hour += working_hour;
                total_wage+= working_hour * wage_per_hour;
 
            }
            Console.WriteLine( $"Working day of Employee {working_day-1}\nTotal Working hours {total_hour}" );
            Console.WriteLine($"Employee woked in a month as\nFullTime: {fullday} \nParTime: {halfday}\nAbsent: {absent}");
            Console.WriteLine($"The Wages of Employee per month: {total_wage} ");

        }
    }
}
