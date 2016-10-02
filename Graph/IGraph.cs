using System;
using System.Collections.Generic;

namespace Graph
{
    /// <summary>
    /// Represents a graph.
    /// </summary>
    /// <typeparam name="V">The vertex type.</typeparam>
    /// <typeparam name="E">The edge type.</typeparam>
    public interface IGraph<V, E> : IEquatable<IGraph<V, E>> where E: IEdge<V>
    {
        /// <summary>
        /// The graph's vertices.
        /// </summary>
        ISet<V> Vertices { get; }

        /// <summary>
        /// Attempts to add an edge to the graph.
        /// </summary>
        /// <param name="edge">
        /// The edge.
        /// </param>
        /// <param name="allowNewVertices">
        /// Iff true, add vertices in the edge which aren't yet in the graph
        /// to the graph's vertex set.
        /// </param>
        /// <returns>
        /// True iff the edge was successfully added.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown if the edge contains at least one edge not in the graph,
        /// and allowNewVertices is set to false.
        /// </exception>
        bool TryAddEdge(E edge, bool allowNewVertices = false);
    }
}
