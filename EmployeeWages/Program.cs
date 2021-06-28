using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Computation Program");
            int present = 1;
            Random random = new Random();
            int emp_Input = random.Next(0, 2);
           
            if (emp_Input==present)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }

        }
    }
}
