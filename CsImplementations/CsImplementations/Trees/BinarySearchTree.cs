using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
    public class BinarySearchTree<T> where T : IComparable
    {
        // TODO: implement IEnumerable interface

        private Node _root;

        private class Node
        {
            public T Value;
            public Node Left;
            public Node Right;
        }

        /// <summary>
        /// Add a new value to the tree.
        /// </summary>
        /// <param name="value"></param>
        public void Insert(T value)
        {
            this._root = Insert(this._root, value);
        }

        private Node Insert(Node node, T value)
        {
            if (node is null)
            {
                node = new Node
                {
                    Value = value,

                    Left = null,
                    Right = null
                };
            }
            else if (value.CompareTo(value) < 0)
            {
                node.Left = Insert(node.Left, value);
            }
            else if (value.CompareTo(value) >= 0)
            {
                node.Right = Insert(node.Right, value);
            }

            return node;
        }

        /// <summary>
        /// Removes a value from the tree.
        /// </summary>
        /// <param name="value"></param>
        public void Delete(T value)
        {
            this._root = Delete(this._root, value);
        }

        private Node Delete(Node node, T value)
        {
            if (node is null)
            {
                return null;
            }
            else if (node.Value.CompareTo(value) < 0)
            {
                node.Left = Delete(node.Left, value);
            }
            else if (node.Value.CompareTo(value) > 0)
            {
                node.Right = Delete(node.Right, value);
            }
            else //node.Value.CompareTo(value) == 0
            {
                if (node.Right is null)
                    return node.Left;

                if (node.Left is null)
                    return node.Right;

                Node temp = node;
                node = Min(temp.Right);
                node.Right = DeleteMin(temp.Right);
                node.Left = temp.Left;
            }

            return node;
        }

        private Node DeleteMin(Node node)
        {
            if (node.Left is null)
            {
                return node.Right;
            }

            node.Left = DeleteMin(node.Left);

            return node;
        }

        private Node Min(Node node)
        {
            if (node.Left is null)
            {
                return node;
            }

            return Min(node.Left);
        }

        /// <summary>
        /// Gets whether the tree contains the specified value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Contains(T value)
        {
            // traverse the tree to find the value
            return Contains(value, this._root);
        }//Contains

        private bool Contains(T value, Node node)
        {
            if (node is null)
            {
                return false;
            }
            else if (node.Value.CompareTo(value) == 0)
            {
                return true;
            }
            else if (node.Value.CompareTo(value) < 0)
            {
                // search right subtree
                return Contains(value, node.Right);
            }
            else //node.Value.CompareTo(value) > 0
            {
                // search left subtree
                return Contains(value, node.Left);
            }
        }//Contains
    }//class
}
