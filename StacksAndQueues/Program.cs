﻿namespace StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stacks and Queues Data Structure Program");

            Console.WriteLine("----------Stack Operation----------");
            StackOperationUsingLinkedList stackOperation = new StackOperationUsingLinkedList();

            stackOperation.Push(70);
            stackOperation.Push(30);
            stackOperation.Push(56);
            stackOperation.IsEmpty();
            stackOperation.Display();

            Console.WriteLine("----------Queue Operation----------");
            QueuesOperationUsingLinkedList queueOperation = new QueuesOperationUsingLinkedList();

            queueOperation.Enqueue(56);
            queueOperation.Enqueue(30);
            queueOperation.Enqueue(70);
            queueOperation.Dqueue();
            queueOperation.DisplayQueue();
            
        }
    }
}