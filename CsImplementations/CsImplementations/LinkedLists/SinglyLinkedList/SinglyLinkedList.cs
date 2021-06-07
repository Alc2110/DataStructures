using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedLists
{
    /// <summary>
    /// Simple singly-linked list.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SinglyLinkedList<T> where T : IComparable
    {
        private class Node
        {
            public T Data;
            public Node Next;
        }

        private Node _head;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public SinglyLinkedList()
        {

        }

        /// <summary>
        /// Constructor to create it from a collection of items.
        /// </summary>
        /// <param name="collection"></param>
        public SinglyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
                Append(item);
        }

        /// <summary>
        /// Gets the number of items in the list.
        /// </summary>
        public int Count
        {
            get
            {
                if (this._head is null)
                {
                    // list is empty
                    return 0;
                }
                else
                {
                    // list is not empty, traverse it to the end and count
                    Node currNode = this._head;
                    int count = 0;
                    while (currNode.Next != null)
                    {
                        currNode = currNode.Next;
                        count++;
                    }
                    count++;

                    return count;
                }
            }
        }

        /// <summary>
        /// Gets the first item in the list.
        /// </summary>
        public T First
        {
            get => this._head.Data;
        }

        /// <summary>
        /// Gets the item at the end of the list.
        /// </summary>
        public T Last
        {
            get
            {
                if (this._head is null)
                {
                    // list is empty
                    return default(T);
                }
                else
                {
                    // list is not empty, traverse it to the end
                    Node currNode = this._head;
                    while (currNode.Next != null)
                    {
                        currNode = currNode.Next;
                    }

                    return currNode.Data;
                }
            }
        }

        /// <summary>
        /// Adds an item to the end of the list.
        /// </summary>
        /// <param name="node"></param>
        public void Append(T item)
        {
            // create a new node
            Node newNode = new Node();
            newNode.Data = item;

            if (this._head is null)
            {
                // list is empty, set the head to the new node
                this._head = newNode;
            }
            else
            {
                // list is not empty, traverse it to the end and append it
                Node currNode = this._head;
                while (currNode.Next != null)
                {
                    currNode = currNode.Next;
                }

                currNode.Next = newNode;
            }
        }

        /// <summary>
        /// Adds an item to the beginning of the list.
        /// </summary>
        /// <param name="node"></param>
        public void Prepend(T item)
        {
            // create a new node
            Node newNode = new Node();
            newNode.Data = item;

            // set the head to it
            newNode.Next = this._head;
            this._head = newNode;
        }

        /// <summary>
        /// Inserts an item to the list at the proper position.
        /// </summary>
        /// <param name="node"></param>
        public void Insert(T item)
        {
            // create a new node
            Node newNode = new Node();
            newNode.Data = item;

            if (this._head is null)
            {
                // list is empty
                // make the new node the first node
                this._head = newNode;
                newNode.Next = null;
            }
            else
            {
                // list is not empty
                Node currNode = this._head;
                Node prevNode = null;

                // skip all nodes whose values are less than the new value
                while (currNode != null && currNode.Data.CompareTo(item) < 0)
                {
                    prevNode = currNode;
                    currNode = currNode.Next;
                }

                if (prevNode is null)
                {
                    // the new node will be the first in the list
                    this._head = newNode;
                    newNode.Next = currNode;
                }
                else
                {
                    // insert the new node after the previous node
                    prevNode.Next = newNode;
                    newNode.Next = currNode;
                }
            }
        }

        /// <summary>
        /// Deletes the first instance of the specified item.
        /// </summary>
        /// <param name="node"></param>
        public void Delete(T item)
        {
            if (this._head is null)
            {
                return;
            }
            else
            {
                Node currNode = this._head;
                Node prevNode = new Node();
                while (currNode.Next != null)
                {
                    if (currNode.Data.Equals(item))
                    {
                        // delete this node
                        prevNode.Next = currNode.Next;
                    }

                    prevNode = currNode;
                    currNode = currNode.Next;
                }
            }
        }

        /// <summary>
        /// Removes the first item from the list.
        /// </summary>
        public void RemoveFirst()
        {
            // remove first node
            Node obsoleteNode = this._head;

            // point past deleted node
            this._head = this._head.Next;
        }

        /// <summary>
        /// Removes the last item from the list.
        /// </summary>
        public void RemoveLast()
        {
            if (this._head is null)
            {
                return;
            }
            else
            {
                Node currNode = this._head;
                Node prevNode = new Node();
                while (currNode.Next != null)
                {
                    prevNode = currNode;
                    currNode = currNode.Next;
                }

                prevNode.Next = null;
            }
        }

        /// <summary>
        /// Gets whether the specified item is present in the list.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public bool Contains(T item)
        {
            bool contains = false;

            if (!(this._head is null))
            {
                Node currNode = this._head;
                while (currNode.Next != null)
                {
                    if (currNode.Data.Equals(item))
                    {
                        contains = true;
                        break;
                    }
                    currNode = currNode.Next;
                }
            }

            return contains;
        }

        /// <summary>
        /// Removes all items from the list.
        /// </summary>
        /// <returns></returns>
        public void Clear()
        {
            if (this._head is null)
            {
                return;
            }
            else
            {
                this._head = null;
            }
        }

        /// <summary>
        /// Gets all items as a generic List.
        /// </summary>
        /// <returns></returns>
        public List<T> ToList()
        {
            List<T> items = new List<T>();

            if (this._head is null)
            {
                return items;
            }
            else
            {
                // list is not empty, traverse it to the end and count
                Node currNode = this._head;
                while (currNode.Next != null)
                {
                    items.Add(currNode.Data);
                    currNode = currNode.Next; 
                }
                items.Add(currNode.Data);

                return items;
            }
        }//ToList
    }//class
}
