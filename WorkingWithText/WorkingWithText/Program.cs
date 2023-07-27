using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithText
{
    internal class Program
    {
        public static void DoApp()
        {
            string m = "Welcome to Csharp";
            Console.WriteLine(m);
            Console.WriteLine("spliting string\n");
            string[] split = m.Split(' ');
            foreach(string s in split)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(m.IndexOf("to"));
            Console.WriteLine("Converting to uppercase "+m.ToUpper());
            Console.WriteLine("Converting to lowercase "+m.ToLower());
            Console.WriteLine("Length "+m.Length);

        }
        static void Main(string[] args)
        {
            DoApp();
            Console.ReadKey();
        }
    }
}
