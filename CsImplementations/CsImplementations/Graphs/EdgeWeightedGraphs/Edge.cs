using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DataStructures.Graphs.EdgeWeightedGraphs
{
    /// <summary>
    /// An edge in an edge-weighted graph.
    /// </summary>
    public class Edge : IComparable<Edge>
    {
        private readonly int _v; // one vertex
        private readonly int _w; // the other vertex

        private readonly double _weight; // edge weight

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="v">One vertex</param>
        /// <param name="w">The other vertex</param>
        /// <param name="weight">Edge weight</param>
        public Edge(int v, int w, double weight)
        {
            this._v = v;
            this._w = w;

            this._weight = weight;
        }

        public double Weight { get => this._weight; }

        public int Either { get => this._v; }

        public int CompareTo([AllowNull] Edge other)
        {
            var that = other;
            if (this.Weight < that.Weight)
            {
                return -1;
            }
            else if (this.Weight > that.Weight)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Other(int vertex)
        {
            if (vertex == this._v)
            {
                return this._w;
            }
            else if (vertex == this._w)
            {
                return this._v;
            }
            else
            {
                throw new ArgumentException("Invalid vertex");
            }
        }

        public override string ToString()
        {
            return this._v + "-" + this._w + " " + this._weight;
        }//ToString
    }//class
}
