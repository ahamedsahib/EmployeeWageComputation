using System;

namespace EmployeeWages
{
    class Program
    {
        public const int fullTime = 1;
        public const int partTime = 2;
        public const int wage_per_hour = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Computation Program");
            
            int working_hour_per_day = 0;
            int wage_per_day = 0;

            Random random = new Random();
            int emp_Input = random.Next(0, 3);

            switch (emp_Input)
            {
                case fullTime:
                    Console.WriteLine("Employee is present and working as full time");
                    working_hour_per_day = 8;
                    break;
                case partTime:
                    Console.WriteLine("Employee is present and working as part time");
                    working_hour_per_day = 4;
                    break;
                default:
                    Console.WriteLine("Employee is absent");
                    break;

            }
           
            wage_per_day = working_hour_per_day * wage_per_hour;
            Console.WriteLine($"The wage of Employee per day: {wage_per_day} ");

        }
    }
}
