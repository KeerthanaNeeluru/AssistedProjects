using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class Program
    {
        public static void PrinViaRecurion(string[] stu,int index)
        {
            if (index < 0 || index >= stu.Length)
            {
                return;
            }
            Console.WriteLine(stu[index]);
            PrinViaRecurion(stu,index+1);
        }
        public static void RunApp()
        {
            string[] stu = { "Alice", "Eva", "Alen", "Dave", "Charlie" };
            Console.WriteLine("Printing student names");
            PrinViaRecurion(stu,0);
        }
        static void Main(string[] args)
        {
            RunApp();
            Console.ReadKey();
        }
    }
}
