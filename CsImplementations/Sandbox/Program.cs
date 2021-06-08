using System;
using System.Collections;
using System.Collections.Generic;
using DataStructures;
using DataStructures.LinkedLists;
using DataStructures.Stacks;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListSteque<int> steque = new LinkedListSteque<int>();
            steque.Enqueue(1);
            steque.Enqueue(2);
            steque.Enqueue(3);
            steque.Push(4);
            //steque.Pop();
            steque.Clear();
            steque.Enqueue(1);
            steque.Push(1);
            Console.WriteLine("Peeking queue: " + steque.Peek());
            
            Console.WriteLine("\r\nPrinting steque...");
            foreach (var i in steque.ToList())
                Console.WriteLine(i);
            
            Console.WriteLine("\r\nNumber of items in steque: " + steque.Count);

            Console.WriteLine();

            Console.WriteLine(steque.Contains(1));
            Console.WriteLine(steque.Contains(2));
            Console.WriteLine(steque.Contains(3));
            Console.WriteLine(steque.Contains(4));
            Console.WriteLine(steque.Contains(5));
            

            Console.ReadKey();
        }
    }
}
