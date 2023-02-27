using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Algorithm Programs");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n Enter the Option GivenBelow: \n 1.InsertionSort \n 2.BubbleSort \n 3.PrimeNumber " +
                    "Within the range " +
                    "\n 4.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        InsertionSort sort = new InsertionSort();
                        sort.Insertion();
                        break;
                    case 2:
                        BubbleSorting bubble = new BubbleSorting();
                        bubble.Sort();
                        break;
                    case 3:
                        PrimeNumber num = new PrimeNumber();
                        num.PrimeNum();
                        break;
                    default:
                        Console.WriteLine("Enter a valid Option");
                        break;
                }
            }
        }
    }
}

