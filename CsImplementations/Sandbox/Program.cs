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
            LinkedListQueue<int> queue = new LinkedListQueue<int>();
            queue.Enqueue(3);
            queue.Enqueue(2);
            queue.Enqueue(1);
            //queue.Clear();
            queue.Enqueue(53);

            /*
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            */
            //Console.WriteLine("Number of items in queue: " + queue.Count);

            Console.WriteLine("Contains 3: " + queue.Contains(3));
            Console.WriteLine("Contains 2: " + queue.Contains(2));
            Console.WriteLine("Contains 1: " + queue.Contains(1));
            Console.WriteLine("Contains 53: " + queue.Contains(53));
            Console.WriteLine("Contains 300: " + queue.Contains(300));

            Console.ReadKey();
        }
    }
}
