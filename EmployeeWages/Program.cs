using System;

namespace EmployeeWages
{
    class Program
    {
        public const int fullTime = 1;
        public const int partTime = 2;
        public const int wage_per_hour = 20;
        public const int max_working_day = 20;
        public const int max_working_hour = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Computation Program");
            ComputeWage();
        }
        public static void ComputeWage()
        {
            //initalizing instance variables
            int working_hour = 0;
            int total_hour = 0;
            int working_day = 0;


            while (working_hour <= max_working_hour && working_day <= max_working_day)
            {

                Random random = new Random();
                int emp_Input = random.Next(0, 3);

                switch (emp_Input)
                {
                    case fullTime:
                        working_hour = 8;
                        break;
                    case partTime:
                        working_hour = 4;
                        break;
                    default:
                        working_hour = 0;
                        break;

                }
                working_day++;
                total_hour += working_hour;//calculate No of workings Hours Present by Employee

            }
            //Compute total wage
            int total_wage = total_hour * wage_per_hour;
            Console.WriteLine($"Working day of Employee {working_day - 1}\nTotal Working hours {total_hour}");
            Console.WriteLine($"The Wages of Employee per month: {total_wage} ");

        }
    }
}
