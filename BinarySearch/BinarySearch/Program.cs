using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        public static int binary_search(int[] arr, int sitem)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == sitem)
                {
                    return mid;
                }
                else if (arr[mid] < sitem)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 20, 25, 35, 40, 45 };
            Console.WriteLine("Enter item to search using binary search");
            int sitem = int.Parse(Console.ReadLine());
            int res = binary_search(arr, sitem);
            if (res != -1)
            {
                Console.WriteLine($"{sitem} found at index {res}");
            }
            else
            {
                Console.WriteLine($"{sitem} is not present in the given array");
            }
            Console.ReadKey();
        }
    }
}
