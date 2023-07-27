using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        public static void bubblesort(int[] arr)
        {
            int n = arr.Length;
            bool swap;
            for (int i = 0; i < n; i++)
            {
                swap = false;
                for (int j = 0; j < n - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swap = true;
                    }
                }
                if (!swap)
                {
                    break;
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
            bubblesort(arr1);
            Console.WriteLine("After sorting");
            print(arr1);
            Console.ReadKey();
        }
    }
}
