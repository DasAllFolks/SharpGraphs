using System;
using System.Collections.Generic;

namespace Graph
{
    /// <summary>
    /// Implements shared functionality among both 
    /// see cref="SimpleGraph{V, E, W}"/>s and
    /// <see cref="MultiGraph{V, E, W}"/>s.
    /// </summary>
    /// <typeparam name="V">
    /// The type used to create vertex (node) labels.
    /// </typeparam>
    /// <typeparam name="E">The edge type.</typeparam>
    /// <typeparam name="W">
    /// The type used for the edge weight.
    /// </typeparam>
    public abstract class AbstractGraph<V, E, W> : IGraph<V, E, W>
        where V : struct, IEquatable<V>
        where E : IEdge<V, W>
        where W : struct, IComparable<W>, IEquatable<W>
    {
        /// <summary>
        /// The graph's vertices.
        /// </summary>
        protected readonly ISet<V> vertices = new HashSet<V>();

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
            return vertices.Add(vertex);
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
            return vertices.Remove(vertex);
        }
    }
}
