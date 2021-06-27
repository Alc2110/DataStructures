using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Graphs
{
    /// <summary>
    /// Directed graph.
    /// </summary>
    /// <remarks>
    /// Identical to undirected graph, except that AddEdge() only calls Add() once,
    /// and it has a GetReverse() method.
    /// </remarks>
    public class Digraph : Graph
    {
        public Digraph(int v) : base(v)
        {

        }

        public override void AddEdge(int v, int w)
        {
            // add to adjacency list
            this._adj[v].Add(w);

            // increment edge count
            this._E++;
        }

        public Digraph GetReverse()
        {
            Digraph reverse = new Digraph(this._V);
            for (int v = 0; v < V; v++)
            {
                foreach (int w in this._adj[v])
                {
                    reverse.AddEdge(w, v);
                }
            }

            return reverse;
        }//GetReverse
    }//class
}
