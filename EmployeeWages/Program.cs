using System;

namespace EmployeeWages
{
    class Program
    {
        public const int fullTime = 1;
        public const int partTime = 2;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Computation Program");
            ComputeWage("Amazon",30,19,85);
            ComputeWage("Google", 40,22,90);
        }
        public static void ComputeWage(string company,int wage_per_hour,int max_working_day,int  max_working_hour)
        {
            //initalizing instance variables
            int working_hour;
            int total_hour = 0;
            int working_day = 0;


            while (total_hour <= max_working_hour && working_day < max_working_day)
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
            Console.WriteLine($"The Employee Wage of {company} per Month is {total_wage}");

        }
    }
}
