using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    internal class Program
    {
        public static void QuickSort(int[] array)
        {
            if (array == null || array.Length <= 1)
                return;

            QuickSortRecursive(array, 0, array.Length - 1);
        }

        private static void QuickSortRecursive(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high);
                QuickSortRecursive(array, low, pivotIndex - 1);
                QuickSortRecursive(array, pivotIndex + 1, high);
            }
        }

        private static int Partition(int[] array, int low, int high)
        {
            int pivotValue = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivotValue)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, high);
            return i + 1;
        }
        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        static void Main(string[] args)
        {
            int[] marks = { 48, 19, 57, 32, 84, 71, 87, 6, 39, 1, 66, 97, 61, 92, 63, 22, 50, 43, 9, 79 };
            Console.WriteLine("\nOriginal Array 2: " + string.Join(", ", marks));
            QuickSort(marks);
            Console.WriteLine("Sorted Array 2:\n " + string.Join(", ", marks));
            Console.ReadKey();
        }
    }
}
