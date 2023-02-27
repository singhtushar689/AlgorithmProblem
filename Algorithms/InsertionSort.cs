using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class InsertionSort
    {
        public void Insertion()
        {
            int[] arr = { 34, 5, 6, 44, 66, 74, 89, 51 };

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j].CompareTo(arr[j - 1]) < 0)
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
            }
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

        }
    }
}
