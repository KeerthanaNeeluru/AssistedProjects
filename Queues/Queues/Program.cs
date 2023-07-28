using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            Console.WriteLine("peek "+queue.Peek());
            Console.WriteLine("REmove value from queue "+queue.Dequeue());
            Console.WriteLine("peek " + queue.Peek());
            Console.ReadKey();
        }
    }
}
