using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataStructures.Stacks
{
    /// <summary>
    /// Stack implemented with array.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ArrayStack<T>
    {
        private int _maxSize;
        public int Capacity { get => this._maxSize; }

        private T[] _items;

        // reports the number of items pushed so far
        private int _top;
        public int Count { get => this._top; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="capacity">Number of possible items in the stack.</param>
        public ArrayStack(int capacity)
        {
            this._items = new T[capacity];
            this._maxSize = capacity;
            this._top = 0;
        }

        public bool IsEmpty() => this._maxSize == 0;

        /// <summary>
        /// Inserts an item at the top of the stack.
        /// </summary>
        /// <param name="item"></param>
        /// <exception cref="StackOverflowException">Thrown when stack is full.</exception>
        public void Push(T item)
        {
            if (this._top == this._maxSize)
            {
                // overflow
                throw new StackOverflowException("Attempt to push too many items onto the stack.");
            }
            else
            {
                this._items[this._top] = item;
                this._top = this._top + 1;
            }
        }

        /// <summary>
        /// Removes the item at the top of the stack.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException">Thrown when stack is empty.</exception>
        public T Pop()
        {
            if (this._top == 0)
            {
                // stack underflow
                throw new InvalidOperationException("Can't pop or peek from empty stack.");
            }
            else
            {
                this._top = this._top - 1;
                T item = this._items[this._top];

                return item;
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

        /// <summary>
        /// Removes all items from the stack.
        /// </summary>
        public void Clear()
        {
            Array.Clear(this._items, 0, this._items.Length);
            this._top = 0;
        }

        /// <summary>
        /// Gets whether the stack contains the given item.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(T item)
        {
            return this._items.Contains(item);
        }
    }
}
