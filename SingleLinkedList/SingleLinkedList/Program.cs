using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    internal class Program
    {
        public static void RunApp() {
            LinkedList linkedList = new LinkedList();
            Node fnode = new Node
            {
                data = 12,
                next = null
            };
            linkedList.head = fnode;
            Node snode = new Node
            {
                data = 23,
                next = null
            };
            fnode.next = snode;
            Node tnode = new Node
            {
                data = 34,
                next = null
            };
            snode.next = tnode;
            linkedList.Printlist();
        }
        static void Main(string[] args)
        {
            RunApp();
            Console.ReadKey();

        }
    }
}
