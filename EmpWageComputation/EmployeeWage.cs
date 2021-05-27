using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{
    public class EmployeeWage
    {

        const int IS_PRESENT = 1;
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        const int EMP_RATE_PER_HOUR = 20;
        const int NUMBER_OF_WORKING_DAYS = 20;
        const int MAX_HRS_IN_MONTH = 100;
        int EmpHrs = 0;
        int Wage = 0;
        int TotalWorkingDays = 0;
        int totalEmpHrs = 0;
        public void Attendance()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
        }
        public void Calculatewage()
        {
            int EmpHrs = 8;
            int Wage = EMP_RATE_PER_HOUR * EmpHrs;
            Console.WriteLine("wage" + Wage);
        }
        public void MaxDays()
        {
            while (EmpHrs <= MAX_HRS_IN_MONTH && TotalWorkingDays < NUMBER_OF_WORKING_DAYS)
            {
                TotalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        EmpHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        EmpHrs = 8;
                        break;
                    default:
                        EmpHrs = 0;
                        break;
                }
                totalEmpHrs = totalEmpHrs + EmpHrs;
                Console.WriteLine("days" + TotalWorkingDays + "emphrs :" + EmpHrs);
            }
            Wage = EmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Wage" + Wage);
        }
    }
}


