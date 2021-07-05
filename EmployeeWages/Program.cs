using System;

namespace EmployeeWages
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Computation Program");
            EmpBuilderArray emp = new EmpBuilderArray();
            emp.AddCompanyWage("Amazon", 30, 19, 85);
            emp.AddCompanyWage("Google", 40, 22, 90);
            emp.ComputeEmpWage();
          
            Console.WriteLine($"Total wage for Amazon Comapany: {emp.GetTotalWage("Amazon")}");
            Console.WriteLine($"Total wage for Google Comapany: {emp.GetTotalWage("Google")}");

        }
        
    }
}
