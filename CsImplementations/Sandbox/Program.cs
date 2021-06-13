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
            RandomBag<int> bag = new RandomBag<int>();
            bag.Add(1);
            bag.Add(3);
            bag.Add(2);
            bag.Add(4);

            Console.WriteLine("Size: " + bag.GetSize());
            foreach (var i in bag)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
