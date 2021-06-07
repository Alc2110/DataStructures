using System;
using System.Collections;
using System.Collections.Generic;
using DataStructures.LinkedLists;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();
            singlyLinkedList.Append(2);
            singlyLinkedList.Append(3);
            singlyLinkedList.Append(66);
            singlyLinkedList.Append(88);
            singlyLinkedList.Append(94);
            singlyLinkedList.Append(100);
            //singlyLinkedList.RemoveFirst();
            //singlyLinkedList.Delete(94);
            //singlyLinkedList.RemoveLast();
            //singlyLinkedList.Clear();
            singlyLinkedList.Insert(1);
            singlyLinkedList.Insert(95);
            singlyLinkedList.Insert(101);
            foreach (var item in singlyLinkedList.ToList())
            {
                Console.WriteLine(item);
            }

           
            Console.WriteLine("Size: " + singlyLinkedList.Count);
            Console.WriteLine("Last item: " + singlyLinkedList.Last);
            

            /*
            Console.WriteLine("Contains 66: " + singlyLinkedList.Contains(66));
            Console.WriteLine("Contains 200: " + singlyLinkedList.Contains(200));
            */

            Console.ReadKey();
        }
    }
}
