using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class FlipCoin
    {
        public static void FlipCoinTest()
        {
            int noOfTime;
            int countHead = 0;
            int countTail = 0;
            Console.WriteLine("Enter the number of time to flip coin : ");
            noOfTime = Convert.ToInt32(Console.ReadLine());
            for (int start = 0; start < noOfTime; start++)
            {
                Random random = new Random();
                double flip = random.Next(0, 1);
                if (flip < 0.5)
                {
                    countTail++;
                }
                else
                {
                    countHead++;
                }
            }
            int headTotalCount = countHead;
            int tailTotalCount = countTail;
            Console.WriteLine("Total no of Head : {0} ", headTotalCount);
            Console.WriteLine("Total no of Tail : {0}", tailTotalCount);

            double headPercent = (headTotalCount / noOfTime) * 100; 
            double tailPercent = (tailTotalCount / noOfTime) * 100;

            Console.WriteLine("Head Percentage : {0}", headPercent);
            Console.WriteLine("Tail Percentage : {0}", tailPercent);


        }
    }
}
