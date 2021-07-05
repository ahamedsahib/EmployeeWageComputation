using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class EmpWage
    {
        public string company;
        public int wage_per_hour;
        public int max_working_day;
        public int max_working_hour;
        public int total_wage;

        public EmpWage(string company, int wagePerHour, int workingDaysPerMonth, int maxWorkingHours)
        {
            this.company = company;
            this.wage_per_hour = wagePerHour;
            this.max_working_day = workingDaysPerMonth;
            this.max_working_hour = maxWorkingHours;
        }
         public void TotalEmpWage(int totalEmpWage)
        {
            total_wage = totalEmpWage;
        }
        public string toString()
        {
            return $"Total EmpWage For company {this.company} is {this.total_wage}";
        }
    }
}
