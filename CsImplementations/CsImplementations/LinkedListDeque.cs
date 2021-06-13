using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    /// <summary>
    /// Deque implemented with doubly-linked list.
    /// </summary>
    public class LinkedListDeque<T> : IEnumerable<T>
    {
        private class Node
        {
            public T Item;
            public Node Previous;
            public Node Next;
        }

        private Node _first;
        private Node _last;
        private int _n; // number of elements in the deque

        /// <summary>
        /// Construct an empty deque.
        /// </summary>
        public LinkedListDeque()
        {
            this._n = 0;
        }

        /// <summary>
        /// Gets the number of items in the deque.
        /// </summary>
        public int Count
        {
            get => this._n;
        }

        /// <summary>
        /// Gets whether the number of items in the deque is zero.
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => this.GetSize() == 0;

        /// <summary>
        /// Gets the number of items in the deque.
        /// </summary>
        /// <returns></returns>
        public int GetSize() => this._n;

        /// <summary>
        /// Adds an item to the left end of the deque.
        /// </summary>
        /// <param name="item"></param>
        public void PushLeft(T item)
        { 
            // create a new node
            Node newNode = new Node();
            newNode.Item = item;

            if (this._first is null)
            {
                // set it as the first, and the last, node
                this._first = newNode;
                this._last = newNode;
            }
            else
            {
                // set the new node as the first node
                Node oldFirst = this._first;
                newNode.Previous = null;
                newNode.Next = oldFirst;
                oldFirst.Previous = newNode;
                this._first = newNode;
            }

            this._n++;
        }

        /// <summary>
        /// Adds an item to the right end of the deque.
        /// </summary>
        /// <param name="item"></param>
        public void PushRight(T item)
        {
            // create a new node
            Node newNode = new Node();
            newNode.Item = item;

            if (this._last is null)
            {
                // set it as the first, and the last, node
                this._first = newNode;
                this._last = newNode;
            }
            else
            {
                // set the new node as the last node
                Node oldLast = this._last;
                newNode.Previous = oldLast;
                newNode.Next = null;
                oldLast.Next = newNode;
                this._last = newNode;
            }

            this._n++;
        }

        /// <summary>
        /// Removes all items from the deque.
        /// </summary>
        public void Clear()
        {
            this._first = null;
            this._last = null;

            this._n = 0;
        }

        /// <summary>
        /// Removes an item from the left end of the deque.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public T PopLeft()
        {
            if (this._n == 0)
            {
                return default(T);
            }

            // remove the first node
            Node firstNode = this._first;
            this._first = this._first.Next;

            this._n--;

            return firstNode.Item;
        }

        /// <summary>
        /// Removes an item from the right end of the deque.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public T PopRight()
        {
            if (this._n == 0)
            {
                return default(T);
            }

            // remove the last node
            Node lastNode = this._last;
            this._last = this._last.Previous;
            this._last.Next = null;

            this._n--;

            return lastNode.Item;
        }

        /// <summary>
        /// Returns the item from the left end of the deque, without removing it.
        /// </summary>
        /// <returns></returns>
        public T PeekLeft()
        {
            T item = this.PopLeft();
            this.PushLeft(item);

            return item;
        }

        /// <summary>
        /// Returns the item from the right end of the deque, without removing it.
        /// </summary>
        /// <returns></returns>
        public T PeekRight()
        {
            T item = this.PopRight();
            this.PushRight(item);

            return item;
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
            throw new NotImplementedException();
        }
    }
}
