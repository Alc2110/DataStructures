using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Graphs.EdgeWeightedGraphs
{
    public class EdgeWeightedGraph
    {
        private readonly int _v; // number of vertices
        private int _E; // number of edges

        private List<Edge>[] _adj; // adjacency lists

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="V"></param>
        public EdgeWeightedGraph(int V)
        {
            this._v = V;
            this._E = 0;

            this._adj = new List<Edge>[V];
            for (int v = 0; v < V; v++)
            {
                this._adj[v] = new List<Edge>();
            }
        }

        public int V { get => this._v; }

        public int E { get => this._E; }

        public void AddEdge(Edge e)
        {
            int v = e.Either;
            int w = e.Other(v);

            this._adj[v].Add(e);
            this._adj[w].Add(e);

            this._E++;
        }
    }
}
