using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    /// <summary>
    /// A stack-ended queue implemented using a linked-list.
    /// </summary>
    public class LinkedListSteque<T>
    {
        private Node _first; // least recently added node
        private Node _last; // most recently added node

        private int _n; // number of items in the queue
        public int Count { get => this._n; }

        public LinkedListSteque()
        {
            this._n = 0;
        }

        private class Node
        {
            public T Item;
            public Node Next;
        }

        /// <summary>
        /// Gets whether the queue is empty.
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => this._n == 0;

        /// <summary>
        /// Push an item onto the stack end of the steque.
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            // add item to the beginning of the linked list

            // create a new node
            Node newNode = new Node();
            newNode.Item = item;

            // make the new node the first node
            newNode.Next = this._first;
            this._first = newNode;

            // if the steque is empty, the first node is also the last node
            if (this.IsEmpty())
            {
                this._last = this._first;
            }

            this._n++;
        }

        /// <summary>
        /// Removes the item at the stack end of the steque.
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            // remove item from the beginning of the linked list
            
            if (this.IsEmpty())
            {
                // steque is empty
                return default(T);
            }

            // grab the item
            T item = this._first.Item;

            // remove the first node from the steque
            this._first = this._first.Next;
            this._n--;
            if (this.IsEmpty())
            {
                this._last = null;
            }

            return item;
        }

        /// <summary>
        /// Gets the item at the stack end of the steque, without removing it.
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            T item = this.Pop();
            this.Push(item);

            return item;
        }

        public void Enqueue(T item)
        {
            // add item to the end of the linked list

            Node oldLast = this._last;
            this._last = new Node();
            this._last.Item = item;
            this._last.Next = null;

            if (this.IsEmpty())
            {
                this._first = this._last;
            }
            else
            {
                oldLast.Next = this._last;
            }

            this._n++;
        }

        /// <summary>
        /// Gets whether the given item is in the queue.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(T item)
        {
            Node currNode = this._first;
            while (currNode.Next != null)
            {
                if (currNode.Item.Equals(item))
                    return true;

                currNode = currNode.Next;
            }

            if (currNode.Item.Equals(item))
                return true;

            return false;
        }//Contains

        /// <summary>
        /// Removes all items from the steque.
        /// </summary>
        public void Clear()
        {
            this._first = null;
            this._last = null;
            this._n = 0;
        }

        /// <summary>
        /// Gets all items as a generic list.
        /// </summary>
        /// <returns></returns>
        public List<T> ToList()
        {
            List<T> items = new List<T>();

            if (this._first is null)
            {
                return items;
            }
            else
            {
                Node currNode = this._first;
                while (currNode.Next != null)
                {
                    items.Add(currNode.Item);

                    currNode = currNode.Next;
                }
                items.Add(currNode.Item);
            }

            return items;
        }//ToList
    }//class
}
