using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class SwapNumber
    {
        public static void SwapNumberCheck()
        {
            Console.Write("Enter the number 1 : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the number 2 : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int originalNumber1 = number1;
            int originalNumber2 = number2;
            int temp;

            //swap logic
            temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine("Value of number 1 before swapping : {0}",originalNumber1);
            Console.WriteLine("Value of number 2 before swapping : {0}", originalNumber2);

            Console.WriteLine("Value of number 1 after swapping : {0}", number1);
            Console.WriteLine("Value of number 2 after swapping : {0}", number2);
            
        }
    }
}
