using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LeapYear
    {
        public static void LeapYearCheck()
        {
            Console.WriteLine("Enter the year : ");
            // variable
            int year = Convert.ToInt32(Console.ReadLine());
            
            //Calculations 
            if (year >= 1000 && year <= 9999)
            {
                if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)){
                    Console.WriteLine("Year : {0} is leap.", year);
                }
                else
                {
                    Console.WriteLine("Year : {0} is not leap.",year);
                }

            }
            else
            {
                Console.WriteLine("Invalid Number entered.");
            }
        
        }
    }
}
