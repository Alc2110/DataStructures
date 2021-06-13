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
            LinkedListDeque<int> deque = new LinkedListDeque<int>();
            deque.PushLeft(1);
            deque.PushLeft(2);
            deque.PushRight(3);
            deque.PushRight(4);

            foreach (var item in deque)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Popping Left: " + deque.PopLeft());
            Console.WriteLine("Popping Right: " + deque.PopRight());
            Console.WriteLine("Popping Right: " + deque.PopRight());
            foreach (var item in deque)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
