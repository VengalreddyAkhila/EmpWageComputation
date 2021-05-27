using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{
    public class EmployeeWage
    { 
            const int IS_PRESENT = 1;
            const int EMP_RATE_PER_HOUR = 20;
        int EmpHrs = 8;
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
            int Wage = EMP_RATE_PER_HOUR * EmpHrs;
            Console.WriteLine("wage" + Wage);


        }
    }
}
