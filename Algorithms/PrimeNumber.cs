using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class PrimeNumber
    {
        public void PrimeNum()
        {
            Console.WriteLine("Enter the starting number ");
            int startingNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the last number ");
            int lastNum = Convert.ToInt32(Console.ReadLine());

            for (int i = startingNum; i <= lastNum; i++)
            {
                int count = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0 && i != 1)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
