using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{

    internal class Program
    {
        public static void Sort(int[] array)
        {
            int n = array.Length;
            int gap = n / 2;

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = array[i];
                    int j = i;

                    while (j >= gap && array[j - gap] > temp)
                    {
                        array[j] = array[j - gap];
                        j -= gap;
                    }

                    array[j] = temp;
                }

                gap /= 2;
            }
        }
        static void Main(string[] args)
        {
            int[] marks = { 64, 34, 25, 42, 52, 81, 90 };
            Console.WriteLine("Original Array: " + string.Join(", ", marks));

            Sort(marks);
            Console.WriteLine("Sorted Array: " + string.Join(", ", marks));
            Console.ReadKey();
        }
    }
}
