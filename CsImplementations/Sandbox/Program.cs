using System;
using System.Collections;
using System.Collections.Generic;
using DataStructures.LinkedLists;
using DataStructures.Stacks;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack<int> stack = new LinkedListStack<int>();
            stack.Push(2);
            stack.Push(3);
            stack.Push(1);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            Console.ReadKey();
        }
    }
}
