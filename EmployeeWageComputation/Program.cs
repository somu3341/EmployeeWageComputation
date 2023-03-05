using System;
namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.Attendance();
            EmployeeWage employee = new EmployeeWage();
            employee.DailyEmWages();         
        }
    }
}