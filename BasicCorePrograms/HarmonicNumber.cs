using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class HarmonicNumber
    {
        public static void CalculateHarmonicNumber()
        {
            Console.WriteLine("Enter the Nth number : ");

            int number = Convert.ToInt32(Console.ReadLine());
            double sumOfHarmonicNumber = 0.0;
            for (int i = 1; i <= number; i++)
            {
                sumOfHarmonicNumber = 1 + (1/number);
                Console.Write("1/{0} ",i);
            }
        }
    }
}
