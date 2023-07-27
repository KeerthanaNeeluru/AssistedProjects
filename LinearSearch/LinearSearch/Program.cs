using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    internal class Program
    {
        public static int search(int[] arr, int t)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == t)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = { 10, 2, 3, 4, 5, 6, 7, 21 };
            Console.WriteLine("Enter the value you want to search");
            int t=int.Parse(Console.ReadLine());
            int index = search(arr, t);
            if ( index != -1)
            {
                Console.WriteLine("Value found at index : "+index);
            }
            else
            {
                Console.WriteLine("Value not found");
            }
            Console.ReadKey();
        }
    }
}
