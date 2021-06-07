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
            ArrayStack<int> arrayStack = new ArrayStack<int>(3);
            arrayStack.Push(2);
            arrayStack.Push(3);
            arrayStack.Push(1);

            Console.ReadKey();
        }
    }
}
