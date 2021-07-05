using System;

namespace EmployeeWages
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Computation Program");
            EmpBuilderArray amazon = new EmpBuilderArray("Amazon", 30, 19, 85);
            amazon.ComputeWage();
            EmpBuilderArray google = new EmpBuilderArray("Google", 40, 22, 90);
            google.ComputeWage();
            Console.WriteLine(google.toString());
        }
        
    }
}
