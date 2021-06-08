using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    /// <summary>
    /// A queue implemented using a linked list.
    /// </summary>
    public class LinkedListQueue<T>
    {
        private Node _first; // least recently added node
        private Node _last; // most recently added node

        private int _n; // number of items in the queue
        public int Count { get => this._n; }

        private class Node
        {
            public T Item;
            public Node Next;
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public LinkedListQueue()
        {

        }

        /// <summary>
        /// Constructor to create it from a collection of items.
        /// </summary>
        /// <param name="items"></param>
        public LinkedListQueue(IEnumerable<T> items)
        {
            foreach (var item in items)
                this.Enqueue(item);
        }

        /// <summary>
        /// Gets whether the queue is empty.
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => this._n == 0;

        /// <summary>
        /// Places an item onto the queue.
        /// </summary>
        /// <param name="item"></param>
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
        /// Removes an item from the queue.
        /// </summary>
        /// <returns>Item removed from the queue. If the queue is empty, the default value is returned.</returns>
        public T Dequeue()
        {
            // remove item from the beginning of the linked list

            if (this._n == 0)
            {
                // queue is empty
                return default(T);
            }

            T item = this._first.Item;
            this._first = this._first.Next;
            this._n--;

            if (this.IsEmpty())
            {
                this._last = null;
            }

            return item;
        }

        /// <summary>
        /// Removes all items from the queue.
        /// </summary>
        public void Clear()
        {
            this._first.Next = null;
            this._n = 0;
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
    }//class
}
