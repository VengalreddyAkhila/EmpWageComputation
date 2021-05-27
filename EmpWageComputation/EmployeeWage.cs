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
             int EmpHrs = 0;
             int Wage = 0;   
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
        public void PartTime()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_FULL_TIME:
                    EmpHrs = 8;
                    break;
                case IS_PART_TIME:
                    EmpHrs = 4;
                    break;
                default:
                    EmpHrs = 0;
                    break;
            }
            Wage = EmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("wage:" + Wage);
        }


    }
    
}
