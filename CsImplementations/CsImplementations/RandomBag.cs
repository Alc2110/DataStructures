using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataStructures
{
    /// <summary>
    /// A bag whose iteration provides the elements in random order.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RandomBag<T> : IEnumerable<T>
    {
        private List<T> _items;

        /// <summary>
        /// Constructs and empty random bag.
        /// </summary>
        public RandomBag()
        {
            this._items = new List<T>() { };
        }

        /// <summary>
        /// Adds an item to the random bag.
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            this._items.Add(item);
        }

        /// <summary>
        /// Gets whether the number of elements in the random bag is zero.
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => this.GetSize() == 0;

        /// <summary>
        /// Gets the number of elements in the random bag.
        /// </summary>
        /// <returns></returns>
        public int GetSize() => this._items.Count;

        public IEnumerator<T> GetEnumerator()
        {
            // randomise the list first
            Random rand = new Random();
            this._items = this._items.OrderBy(x => rand.Next()).ToList();

            foreach (var i in this._items)
            {
                yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
