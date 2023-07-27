using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    internal class Program
    {
        public static void selectionsort(int[] arr2)
        {
            int n = arr2.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr2[j] < arr2[min])
                    {
                        min = j;
                    }
                    int temp = arr2[i];
                    arr2[i] = arr2[min];
                    arr2[min] = temp;
                }
            }

        }
        public static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 6, 2, 5, 72, 24, 33, 12, 67 };
            Console.WriteLine("Before sorting");
            print(arr1);
            selectionsort(arr1);
            Console.WriteLine("After sorting");
            print(arr1);
            Console.ReadKey();
        }
    }
}
