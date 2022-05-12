// See https://aka.ms/new-console-template for more information
using StackAndQueue;

Console.WriteLine("Stack Operations Through LinkedList!");

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