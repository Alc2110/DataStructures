using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    /// <summary>
    /// A data structure that supports only adding elements. Removing elements is not allowed.
    /// This implementation uses a singly-linked list.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedListBag<T> : IEnumerable<T>
    {
        private Node _first;

        private class Node
        {
            public T Item;
            public Node Next;
        }

        public void Add(T item)
        {
            // same as push() in Stack
            // create a new node and make it the first node
            Node oldFirst = this._first;
            this._first = new Node();
            this._first.Item = item;
            this._first.Next = oldFirst;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node currNode = this._first;
            while (currNode != null)
            {
                yield return currNode.Item;

                currNode = currNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
