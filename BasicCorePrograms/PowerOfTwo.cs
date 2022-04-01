using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PowerOfTwo
    {
        public static void powerOfTwoProblem()
        {
            Console.WriteLine("Enter the number : ");

            //variables
            int power = 1;

            //inputs
            int number = Convert.ToInt32(Console.ReadLine());

            //Computation
            for (int i = 1;i <= number; i++)
            {
                power = 2 * power;
                Console.WriteLine(power);
            }

            int year = power;
            //Leap Year calculate
            if(power >=1000 && power <= 9999)
            {
                if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
                {
                    Console.WriteLine("Year : {0} is leap.", year);
                }
                else
                {
                    Console.WriteLine("Year : {0} is not leap.", year);
                }
            }
        }
    }
}
