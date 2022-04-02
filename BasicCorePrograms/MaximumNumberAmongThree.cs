using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class MaximumNumberAmongThree
    {
        public static void FindMax()
        {
            int number1,number2,number3;

            Console.Write("Enter number 1 : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2 : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 3 : ");
            number3 = Convert.ToInt32(Console.ReadLine());

            if(number1 > number2  && number1 > number3)
            {
                Console.WriteLine("Number 1 : {0} is greater.", number1);
            }
            else if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine("Number 2 : {0} is greater.",number2);
            }
            else
            {
                Console.WriteLine("Number 3 : {0} is greater.",number3);
            }
        }
    }
}
