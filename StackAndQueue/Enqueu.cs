using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class Enqueu
    {
        QNode front, rear;
        public int Count = 0;
        public Enqueu()
        {
            this.front = this.rear = null;
        }
        public void enqueue(int key)
        {
            Count++;
            QNode temp = new QNode(key);

            if (this.rear == null)
            {
                this.front = this.rear = temp;
                return;
            }

            this.rear.next = temp;
            this.rear = temp;

        }

        public void dequeue()
        {
            if (this.front == null)

                return;


            QNode temp = this.front;
            this.front = this.front.next;

            if (this.front == null)

                this.rear = null;
            Count--;

        }


        public void Display()
        {
            if (front == null)
            {
                Console.Write("Queue Underflow");
                return;
            }
            else
            {
                QNode temp = front;
                while (temp != null)
                {
                    Console.Write("->{0}", temp.key);
                    temp = temp.next;
                }
            }

        }

    }
}
