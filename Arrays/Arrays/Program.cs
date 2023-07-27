using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        public static void RunApp()
        {
            //single dimensional array
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };
            string[] arr2 = { "Red", "Yellow", "Brown", "Pink", "Blue", "Black" };
            int s1 = 0;
            Console.WriteLine("Display integer array");
            foreach (int i in arr1) Console.Write(i+" ");
            Console.WriteLine("\nDisplay string array");
            foreach(string s in arr2) Console.WriteLine(s+" ");
           
            foreach(int i in arr1)
            {
                s1 += i;
            }
            Console.WriteLine("sum of values in  arr1 array is"+s1);
            Console.WriteLine("Average of values in arr1 array is "+(s1/arr1.Length));
            //2d
            int[,] arr3 = new int[2, 3] { { 1, 2, 5 }, { 12, 3, 2 } };
            Console.WriteLine("\n2d array\n");
            for (int i=0; i<2; i++)
            {
                for(int j=0; j<3; j++)
                {
                    Console.Write(arr3[i,j] +" ");
                }
                Console.WriteLine("\n");
            }
            //Jagged array
            int[][] stuscore = new int[3][];
            stuscore[0] = new int[3] { 85, 92, 78 };
            stuscore[1] = new int[4] { 90, 87, 93, 89 };
            stuscore[2] = new int[2] { 76, 88 };
            float avg = 0, sum = 0, allavg = 0, allsum = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Score of student {i + 1}");
                for (int j = 0; j < stuscore[i].Length; j++)
                {
                    sum += stuscore[i][j];
                    avg = sum / stuscore[i].Length;
                    Console.WriteLine(stuscore[i][j]);
                }
                Console.WriteLine("-----------------------");
                Console.WriteLine($"Average score of student {i + 1} is " + avg);
                allsum += avg;
                avg = 0;
                sum = 0;
                Console.WriteLine("-----------------------");
                Console.WriteLine("\n");
                allavg = allsum / 3;
            }

            Console.WriteLine("Average score of all 3 students is :" + allavg);

        }
        static void Main(string[] args)
        {
            RunApp();
            Console.ReadKey();
        }
    }
}
