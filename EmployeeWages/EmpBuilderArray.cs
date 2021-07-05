using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class EmpBuilderArray
    {
        public const int fullTime = 1;
        public const int partTime = 2;

        private string company;
        private int wage_per_hour;
        private int max_working_day;
        private int max_working_hour;
        private int total_wage;

        public EmpBuilderArray(string company, int wagePerHour, int workingDaysPerMonth, int maxWorkingHours)
        {
            this.company = company;
            this.wage_per_hour = wagePerHour;
            this.max_working_day = workingDaysPerMonth;
            this.max_working_hour = maxWorkingHours;
        }
        public  void ComputeWage()
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
            total_wage = total_hour * wage_per_hour;
            Console.WriteLine($"Working day of Employee {working_day - 1}\nTotal Working hours {total_hour}");
            Console.WriteLine($"The Employee Wage of {company} per Month is {total_wage}");

        }
        public string toString()
        {
            return $"Total EmpWage For company {this.company} is {this.total_wage}";
        }
    }
}
