using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class LinkedListMethod<T>
    {

        Node<T> top;

        public int Count = 0;


        public void Push(T x)
        {
            Node<T> temp = new();
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
            Count++;
        }

        public bool isEmpty()
        {
            return top == null;
        }
        public T Peak()
        {
            if (!isEmpty())
            {
                return top.data;

            }
            else
            {
                Console.WriteLine("stack empty");
                return default(T);
            }
        }

        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack underflow");
                return;
            }
            top = (top).link;
            Count--;
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
                Node<T> temp = top;
                while (temp != null)
                {
                    Console.Write("{0}->", temp.data);
                    temp = temp.link;
                }
            }

        }
    }
}
