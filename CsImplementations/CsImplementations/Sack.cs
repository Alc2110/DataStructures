using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    /// <summary>
    /// The idea of this data structure is to hold any number objects of any type. Objects can be retrieved, or removed permanently, at random. Also, it can be cleared (or emptied).
    /// Not very useful in the real-world, but a good exercise in creating and implementing a data structure.
    /// Using object instead of Generics adss casting operations in the background, which is slower and creates the chance of casting exceptions, but the idea is to store many objects of different tyupes.
    /// </summary>
    public class Sack
    {
        private readonly IList<object> _objects = new List<object>();
        private readonly Random _rand = new Random();

        /// <summary>
        /// Constructor. Adds items.
        /// </summary>
        /// <param name="items"></param>
        public Sack(IEnumerable<object> items)
        {
            foreach (var obj in items)
                Add(obj);
        }

        /// <summary>
        /// Add a new item to the sack.
        /// </summary>
        /// <param name="obj"></param>
        public void Add(object obj)
        {
            this._objects.Add(obj);
        }

        /// <summary>
        /// Retrieves a random item from the sack, without removing it. Effectively simulates putting the item back in the sack once we're done looking at it.
        /// </summary>
        /// <returns></returns>
        public object Retrieve()
        {
            // TODO: make this faster
            object selectedObject = this._objects[GetRandomIndex()];

            return selectedObject;
        }

        /// <summary>
        /// Removes a random item from the sack.
        /// </summary>
        /// <returns></returns>
        public object Remove()
        {
            int selectedIndex = GetRandomIndex();
            
            // TODO: make this faster
            object selectedObject = this._objects[selectedIndex];
            this._objects.RemoveAt(selectedIndex);

            return selectedObject;
        }

        private int GetRandomIndex()
        {
            int numberOfObjects = this._objects.Count;
            int selectedIndex = this._rand.Next(0, numberOfObjects);

            return selectedIndex;
        }

        /// <summary>
        /// Clear the items in the sack.
        /// </summary>
        public void Clear()
        {
            this._objects.Clear();
        }

        /// <summary>
        /// Clear the items in the sack, returning them as a list.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> Empty()
        {
            List<object> returnList = new List<object>();
            foreach (var obj in this._objects)
            {
                yield return obj;
            }
            Clear();
        }//Empty
    }//class
}
