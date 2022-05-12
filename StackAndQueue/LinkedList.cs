using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class LinkedList
    {

        Node top;

        public void Push(int x)
        {
            Node temp = new(x);
            if (temp == null)
            {
                Console.WriteLine("Heap overflow");
                return;
            }
            else
            {
                temp.data = x;
                temp.link = top;
                top = temp;
            }

        }
        public void Display()
        {
            if (top == null)
            {
                Console.Write("Stack Underflow");
                return;
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.Write("{0}->", temp.data);
                    temp = temp.link;
                }
            }

        }
    }
}
