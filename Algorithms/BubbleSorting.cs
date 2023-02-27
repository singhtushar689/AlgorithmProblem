using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BubbleSorting
    {
        public void Sort()
        {
            int[] array = { 23, 45, 34, 22, 98, 69, 89 };
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("After sorting: ");
            foreach (var data in array)
            {
                Console.WriteLine(data);
            }
        }
    }
}
