// See https://aka.ms/new-console-template for more information
using StackAndQueue;

Console.WriteLine("Stack Operations Using LinkedList!");

LinkedList linkedList = new();
linkedList.Push(70);
linkedList.Push(30);
linkedList.Push(56);

Console.Write("The Elements of the Stack are : ");
linkedList.Display();
Console.WriteLine("\n");