using System;
using System.Collections;
using System.Collections.Generic;
using DataStructures;
using DataStructures.LinkedLists;
using DataStructures.Stacks;
using DataStructures.Trees;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Insert(1);
            bst.Insert(6);
            bst.Insert(4);
            bst.Insert(5);
            bst.Delete(4);
            bst.Delete(3);

            Console.WriteLine("Contains 1: " + bst.Contains(1));
            Console.WriteLine("Contains 4: " + bst.Contains(4));
            Console.WriteLine("Contains 5: " + bst.Contains(5));
            Console.WriteLine("Contains 6: " + bst.Contains(6));
            Console.WriteLine("Contains 7: " + bst.Contains(7));

            Console.ReadKey();
        }
    }
}
