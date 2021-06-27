using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Graphs
{
    /// <summary>
    /// Undirected graph.
    /// </summary>
    public class Graph
    {
        // number of vertices
        protected int _V;

        // number of edges
        protected int _E = 0;

        // array of adjacency lists
        protected List<int>[] _adj;

        /// <summary>
        /// Constructor to create a graph.
        /// </summary>
        /// <param name="v">Number of vertices</param>
        public Graph(int v)
        {
            this._V = v;

            // create array of lists
            // initialise all lists to empty
            this._adj = new List<int>[v];
            for (int i = 0; i < this._adj.Length; i++)
                this._adj[i] = new List<int>();
        }

        // number of vertices
        public int V
        {
            get { return this._V; }
        }

        // number of edges
        public int E
        {
            get { return this._E; }
        }

        /// <summary>
        /// Add an edge to the graph.
        /// </summary>
        /// <param name="v">One vertex of the new edge.</param>
        /// <param name="w">The other vertex of the new edge.</param>
        public virtual void AddEdge(int v, int w)
        {
            // validate given node numbers
            if (v < 0 || v > this._adj.Length)
            {
                throw new ArgumentOutOfRangeException($"Error, the value provided for 'v' should be" +
                "between 0 and {this._adj.Length - 1}\n" +
                "\tv = {v}\n");
            }

            if (w < 0 || w > this._adj.Length)
            {
                throw new ArgumentOutOfRangeException($"Error, the value provided for 'v' should be" +
                "between 0 and {this._adj.Length - 1}\n" +
                "\tv = {v}\n");
            }

            // add to adjacency lists
            this._adj[v].Add(w);
            this._adj[w].Add(v);
            // increment edge count
            this._E++;
        }

        /// <summary>
        /// Get an adjacency list for a vertex.
        /// </summary>
        /// <param name="v">The vertex.</param>
        /// <returns></returns>
        public List<int> GetAdjacency(int v)
        {
            return this._adj[v];
        }

        /// <summary>
        /// Get a string representation of the graph's adjacency lists.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(this._V + " vertices, " + this._E + " edges");
            for (int v = 0; v < this._V; v++)
            {
                builder.Append(v + ": ");
                foreach (var w in this._adj[v])
                {
                    builder.Append(w + " ");
                }
                builder.AppendLine(string.Empty);
            }

            return builder.ToString();
        }
    }
}
