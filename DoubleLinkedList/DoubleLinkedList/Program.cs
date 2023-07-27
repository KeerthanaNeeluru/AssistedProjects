using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DoubleLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            Node fnode = new Node
            {
                data = 12,
                next = null,
                prev = null,
            };
            linkedList.head = fnode;
            Node snode = new Node
            {
                data = 23,
                next = null
            };
            fnode.next = snode;
            snode.prev = fnode;
            Node tnode = new Node
            {
                data = 34,
                next = null
            };
            snode.next = tnode;
            tnode.prev = tnode;
            linkedList.Printlist();
            Console.ReadKey();
        }
        
    }
}
