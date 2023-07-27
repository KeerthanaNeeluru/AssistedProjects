using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    internal class Program
    {
        public static void DoApp()
        {
            int value;
            int[] arr = {1,2,3,4,5};
            Console.WriteLine("Enter a value");
            value=int.Parse(Console.ReadLine());
            Console.WriteLine("If Condition");
            if (value % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
            Console.WriteLine("For loop");
            for(int i = 0; i < 10; i++)
            {
                Console.Write(i+" ");
                if (i == value)
                {
                    break;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("While loop");
            while (value %2==0)
            {
                Console.Write(value+"\n");
                value++;
            }
            Console.WriteLine("\nDo-While loop");
            do
            {
                Console.Write(value + " ");
                value++;
            } while (value == 10);
            Console.WriteLine("\n foreach loop");
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Select\n1.Welcome\n2.Send off");
            int ch=int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Welcome");
                    break;
                case 2:
                    Console.WriteLine("Bye");
                    break;
                default:break;
            }
        }
        static void Main(string[] args)
        {
            DoApp();
            Console.ReadKey();
        }
    }
}
