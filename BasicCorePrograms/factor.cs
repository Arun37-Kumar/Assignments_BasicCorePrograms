using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class factor
    {
        public static void factorCheck()
        {
            Console.WriteLine("Enter positive number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int originalNumber = 1;

            if (number < 0)
            {
                Console.WriteLine("Invalid Number!");
                Console.ReadLine();
            }
            else
            {
                for(int count = 2; number > 1; count++)
                {
                    while (number%count == 0)
                    {
                        Console.Write("{0} ", count);
                        number /= count;
                        originalNumber *= count;
                    }
                }
                Console.WriteLine("\nOriginal Number after prime factorization : {0}",originalNumber);
                Console.ReadLine();
            }
        }
    }
}
