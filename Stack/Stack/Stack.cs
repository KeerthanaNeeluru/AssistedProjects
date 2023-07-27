using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        public Node top;
        public Stack() {
            top = null;
        }
        public void Push(int d)
        {
            Node n = new Node(d);
            n.next = top;
            top = n;

        }
        public int Pop()
        {
            if (top == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            int d=top.data;
            top= top.next;
            return d;

        }
        public int Peek()
        {
            if(top == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return top.data;
        }

    }
}
