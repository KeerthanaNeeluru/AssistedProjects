using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    internal class Program
    {
        public static int[] generate(int size, int min, int max)
        {
            Random r = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = r.Next(min, max + 1);
            }
            return arr;

        }
        public static void insertion(int[] arr)
        {
            int n = arr.Length;

            for (int i = 1; i < n; i++)
            {
                int currentElement = arr[i];
                int j = i - 1;

                // Move elements that are greater than the currentElement to the right
                while (j >= 0 && arr[j] > currentElement)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                // Insert the currentElement in its correct position
                arr[j + 1] = currentElement;
            }
        }
        public static void print(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int s, min, max;
            Console.WriteLine("Enter the size of array you want to generate");
            s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the minimum value you want in array");
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the maximum value you want in array");
            max = int.Parse(Console.ReadLine());
            int[] a1 = generate(s, min, max);
            print(a1);
            insertion(a1);
            Console.WriteLine("After sorting");
            print(a1);
            Console.ReadKey();
        }
    }
}
