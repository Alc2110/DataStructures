using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Stacks
{
    /// <summary>
    /// Stack implemented with singly-linked list.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedListStack<T> : IEnumerable<T>
    {
        private Node _head;
        private int _numItems;

        private class Node
        {
            public T Item;
            public Node Next;
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public LinkedListStack()
        {

        }

        /// <summary>
        /// Copy constructor. Creates a deep copy.
        /// </summary>
        /// <param name="stack"></param>
        public LinkedListStack(LinkedListStack<T> stack)
        {
            List<T> items = new List<T>() { };

            foreach (var item in stack)
            {
                items.Add(item);
            }
            items.Reverse();

            foreach (var item in items)
            {
                this.Push(item);
            }
        }

        /// <summary>
        /// Adds an item to the stack.
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            Node oldHead = this._head;
            this._head = new Node();
            this._head.Item = item;
            this._head.Next = oldHead;

            _numItems++;
        }

        /// <summary>
        /// Removes the item at the top of the stack.
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            if (this._head != null)
            {
                T item = this._head.Item;
                this._head = this._head.Next;
                this._numItems--;

                return item;
            }
            else
            {
                return default(T);
            }
        }

        /// <summary>
        /// Returns the item at the top of the stack, without removing it.
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            T item = this.Pop();
            this.Push(item);

            return item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node currNode = this._head;
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
