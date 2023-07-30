using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public class LinkedList
    {
        public Node head;
        public LinkedList()
        {
            head = null;
        }
        public void Printlist()
        {

            Node temp = new Node();
            temp = this.head;
            if (temp != null)
            {
                Console.WriteLine("This list contain");
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Yhis list is empty");
            }
        }
        }
}
