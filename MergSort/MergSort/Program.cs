using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergSort
{
    internal class Program
    {
        public static void MergeSort(int[] array)
        {
            if (array == null || array.Length <= 1)
                return;

            int[] tempArray = new int[array.Length];
            MergeSortRecursive(array, tempArray, 0, array.Length - 1);
        }

        private static void MergeSortRecursive(int[] array, int[] tempArray, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                MergeSortRecursive(array, tempArray, low, mid);
                MergeSortRecursive(array, tempArray, mid + 1, high);
                Merge(array, tempArray, low, mid, high);
            }
        }

        private static void Merge(int[] array, int[] tempArray, int low, int mid, int high)
        {
            for (int i = low; i <= high; i++)
            {
                tempArray[i] = array[i];
            }

            int left = low;
            int right = mid + 1;
            int current = low;

            while (left <= mid && right <= high)
            {
                if (tempArray[left] <= tempArray[right])
                {
                    array[current] = tempArray[left];
                    left++;
                }
                else
                {
                    array[current] = tempArray[right];
                    right++;
                }
                current++;
            }

            int remaining = mid - left;
            for (int i = 0; i <= remaining; i++)
            {
                array[current + i] = tempArray[left + i];
            }
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
            MergeSort(marks);
            Console.WriteLine("Sorted Array 2:\n " + string.Join(", ", marks));
            Console.ReadKey();

        }
    }
}
