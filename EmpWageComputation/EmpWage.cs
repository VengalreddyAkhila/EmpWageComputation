using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{
    public class EmpWage
    {
        const int IS_PRESENT = 1;
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        const int EMP_RATE_PER_HOUR = 20;
        int EmpHrs = 0;
        int Wage = 0;
        public void PartTime()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_FULL_TIME)
            {
                EmpHrs = 8;
            }
            else if (empCheck == IS_PART_TIME)
            {
                EmpHrs = 4;
            }
            else
            {
                EmpHrs = 0;
            }
            Wage = EmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("wage:" + Wage);
        }
    }
}
