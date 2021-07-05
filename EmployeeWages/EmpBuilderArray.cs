using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class EmpBuilderArray
    {
        public const int fullTime = 1;
        public const int partTime = 2;

        private int noOfCompanies = 0;
        private EmpWage[] CompanyEmpWageArray;

        public EmpBuilderArray()
        {
            this.CompanyEmpWageArray = new EmpWage[5];
        }

        public void AddCompanyWage(string comp, int wagePerHour, int workingDaysPerMonth, int maxWorkingHours)
        {
            CompanyEmpWageArray[this.noOfCompanies] = new EmpWage(comp, wagePerHour, workingDaysPerMonth, maxWorkingHours);
            noOfCompanies++;
        }
        public void ComputeEmpWage()
        {
            for (int i = 0; i < noOfCompanies; i++)
            {
                CompanyEmpWageArray[i].TotalEmpWage(this.ComputeWage(this.CompanyEmpWageArray[i]));
                Console.WriteLine(this.CompanyEmpWageArray[i].toString());
            }
        }


        private int  ComputeWage(EmpWage empWage)
        {
            //initalizing instance variables
            int working_hour;
            int total_hour = 0;
            int working_day = 0;


            while (total_hour <= empWage.max_working_hour && working_day < empWage.max_working_day)
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
            return total_hour * empWage.wage_per_hour;
            
        }
        
    }
}
