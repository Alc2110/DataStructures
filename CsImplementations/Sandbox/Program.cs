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
            LinkedListStack<int> stack = new LinkedListStack<int>();
            stack.Push(1);
            stack.Push(3);
            stack.Push(2);
            stack.Push(4);

            LinkedListStack<int> stack2 = new LinkedListStack<int>(stack);
            stack2.Push(11);

            Console.WriteLine("Stack 1:");
            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            Console.WriteLine("Stack 2:");
            foreach (var i in stack2)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
