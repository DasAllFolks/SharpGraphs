using System;
using System.Collections.Generic;

namespace Graph
{
    /// <summary>
    /// Represents a simple graph (i.e., as opposed to a
    /// <see cref="MultiGraph{V, E, W}"/>.
    /// </summary>
    /// <typeparam name="V">
    /// The type used to create vertex (node) labels.
    /// </typeparam>
    /// <typeparam name="E">The edge type.</typeparam>
    /// <typeparam name="W">
    /// The type used for the edge weight.
    /// </typeparam>
    public class SimpleGraph<V, E, W> : IGraph<V, E, W>
        where V : struct, IEquatable<V>
        where E : IEdge<V, W>
        where W : struct, IComparable<W>, IEquatable<W>
    {
        /// <summary>
        /// The graph's vertices.
        /// </summary>
        private readonly ISet<V> _vertices = new HashSet<V>();

        /// <summary>
        /// Attempts to add a vertex to the graph.
        /// </summary>
        /// <param name="vertex">The vertex.</param>
        /// <returns>
        /// True if the vertex was successfully added, false if it already
        /// existed.
        /// </returns>
        public bool TryAddVertex(V vertex)
        {
            return _vertices.Add(vertex);
        }

        /// <summary>
        /// Attempts to remove a vertex from the graph.
        /// </summary>
        /// <param name="vertex">The vertex.</param>
        /// <returns>
        /// True if the vertex was successfully removed, false if no such
        /// vertex was found in the graph.
        /// </returns>
        public bool TryRemoveVertex(V vertex)
        {
            return _vertices.Remove(vertex);
        }
    }
}
