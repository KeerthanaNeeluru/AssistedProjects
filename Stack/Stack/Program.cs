using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Program
    {
        public static void RunApp()
        {
            Stack stack=new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            int top1=stack.Peek();
            Console.WriteLine("Top value "+top1);
            int pop1=stack.Pop();
            Console.WriteLine("popped value "+pop1);
            int top2 = stack.Peek();
            Console.WriteLine("Top value " + top2);
            
        }
        static void Main(string[] args)
        {
            RunApp();
            Console.ReadKey();
        }
    }
}
