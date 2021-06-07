using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    /// <summary>
    /// The idea of this data structure is to hold any number objects of any type. Objects can be retrieved, or removed permanently, at random. Also, it can be cleared (or emptied).
    /// Not very useful in the real-world, but a good exercise in creating and implementing a data structure.
    /// </summary>
    public class Sack
    {
        private readonly List<object> objects = new List<object>();
        private readonly Random rand = new Random();

        /// <summary>
        /// Add a new item to the sack.
        /// </summary>
        /// <param name="obj"></param>
        public void Add(object obj)
        {
            objects.Add(obj);
        }

        /// <summary>
        /// Retrieve an item from the sack, optionally removing it from the sack.
        /// </summary>
        /// <param name="remove"></param>
        /// <returns></returns>
        public object Retrieve(bool remove)
        {
            int selectedIndex = rand.Next(0, objects.Count);

            object selectedObject = objects[selectedIndex];

            if (remove)
            {
                objects.RemoveAt(selectedIndex);
            }

            return selectedObject;
        }

        /// <summary>
        /// Clear the items in the sack.
        /// </summary>
        public void Clear()
        {
            objects.Clear();
        }

        /// <summary>
        /// Clear the items in the sack, returning them as a list.
        /// </summary>
        /// <returns></returns>
        public List<object> Empty()
        {
            List<object> returnList = new List<object>();
            foreach (var obj in objects)
            {
                returnList.Add(obj);
            }
            Clear();

            return returnList;
        }//Empty
    }//class
}
