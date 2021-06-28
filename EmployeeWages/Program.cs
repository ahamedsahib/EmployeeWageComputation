using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Computation Program");
            int present = 1;
            int wage_per_hour = 20;
            int working_hour_per_day = 0;
            int wage_per_day = 0;

            Random random = new Random();
            int emp_Input = random.Next(0, 2);
           
            if (emp_Input==present)
            {
                Console.WriteLine("Employee is present");
                working_hour_per_day = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
            wage_per_day = working_hour_per_day * wage_per_hour;
            Console.WriteLine($"The wage of Employee per day: {wage_per_day} ");

        }
    }
}
