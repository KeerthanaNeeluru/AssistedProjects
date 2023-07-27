using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingDates
{
    internal class Program
    {
        public static void DoApp()
        {
            DateTime d1 = new DateTime(2023, 02, 05, 3, 45,0);
            Console.WriteLine(d1);
            DateTime d2 = new DateTime(2022, 03, 21);
            Console.WriteLine(d2);
            DateTime d3 = DateTime.Now;
            Console.WriteLine(d3);
            DateTime d4 = DateTime.UtcNow;
            Console.WriteLine(d4);
            string d5=d1.ToString("dd MM yyyy HH:mm:ss");
            Console.WriteLine(d5);
            DateTime d6 = d2.AddHours(2);
            Console.WriteLine(d6);
            DateTime d7=DateTime.Now.AddDays(10);
            Console.WriteLine(d7);
            DateTime d8= DateTime.Now.AddDays(20);
            Console.WriteLine(d8);
            DateTime d9=DateTime.Now.AddMonths(1);
            Console.WriteLine(d9);
            DateTime d10=DateTime.Now.AddMonths(-2);
            Console.WriteLine(d10);
        }
        static void Main(string[] args)
        {
            DoApp();
            Console.ReadKey();
        }
    }
}
