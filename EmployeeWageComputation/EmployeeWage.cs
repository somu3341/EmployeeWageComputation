using System;
namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        const int IS_PRESENT = 1, WAGE_PER_HR = 20, FULL_DAY_HR = 8, PART_TM_HR = 4, FULL_TIME = 0, PART_TIME = 1;        public void Attendance()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == IS_PRESENT)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
        public void DailyEmWages()
        {           
            int empHrs = 0;
            Random random = new Random();
            int check = random.Next(0, 3);
            if (check == FULL_TIME)               
                empHrs = FULL_DAY_HR;
            if (check == PART_TIME)               
                empHrs = PART_TM_HR;
            else              
                empHrs = 0;
            int wage = WAGE_PER_HR * empHrs;
            Console.WriteLine(wage);
        }       
    }
}
