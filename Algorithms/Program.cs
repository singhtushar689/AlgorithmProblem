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
            InsertionSort sort = new InsertionSort();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n Enter the Option GivenBelow: \n 1.InsertionSort \n 2.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        sort.Insertion();
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}

