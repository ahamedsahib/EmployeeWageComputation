using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    interface IEmployeeWage
    {
        public void AddCompanyWage(string company, int wagePerHour, int workingDaysPerMonth, int maxWorkingHours);
        public void ComputeEmpWage();
        public int GetTotalWage(string company);
    }
}
