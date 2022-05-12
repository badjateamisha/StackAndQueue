// See https://aka.ms/new-console-template for more information
using StackAndQueue;

Console.WriteLine("Stack Operations Through LinkedList!");

while (true)
{
    Console.WriteLine("Select the Program to be Executed :\n1)Stack Implementation\n2)Enqueu method");
    int Option = Convert.ToInt32(Console.ReadLine());
    switch (Option)
    {
        case 1:
            LinkedListMethod<int> linkedList = new();
            linkedList.Push(70);
            linkedList.Push(30);
            linkedList.Push(56);

            Console.Write("The Elements of the Stack are : ");
            linkedList.Display();
            Console.WriteLine("\n");


            int LengthofLL = linkedList.Count;
            for (int i = 0; i < LengthofLL; i++)
            {
                Console.WriteLine("The top Element of the stack is :" + linkedList.Peak());
                linkedList.Pop();
                Console.WriteLine("Number of elements in stack after Pop method : " + linkedList.Count);
            }
            break;

        case 2:
            Enqueu enQueueMethod = new();
            enQueueMethod.enqueue(70);
            enQueueMethod.enqueue(30);
            enQueueMethod.enqueue(56);

            Console.Write("The Elements of the Queue are : ");
            enQueueMethod.Display();
            Console.WriteLine("\n");
            break;
        default:
            break;

    }
}
