using System;

namespace EmpWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Emp Wage Computation");
            EmployeeWage employeewage = new EmployeeWage();
            employeewage.WagesForMonth();
        }
    }
}
