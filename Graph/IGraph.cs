using System;

namespace Graph
{
    /// <summary>
    /// Represents a labeled graph.
    /// </summary>
    /// <typeparam name="V">
    /// The type used to create vertex (node) labels.
    /// </typeparam>
    /// <typeparam name="W">
    /// The type used for the edge weight.
    /// </typeparam>
    public interface IGraph<V, W> : IEquatable<IGraph<V, W>>
        where V : struct, IEquatable<V>
        where W : struct, IComparable<W>, IEquatable<W>
    {
        /// <summary>
        /// Attempts to add a vertex to the graph.
        /// </summary>
        /// <param name="vertex">The vertex.</param>
        /// <returns>
        /// True if the vertex was successfully added, false if it already
        /// existed.
        /// </returns>
        bool TryAddVertex(V vertex);

        /// <summary>
        /// Attempts to remove a vertex from the graph.
        /// </summary>
        /// <remarks>
        /// This will also remove all edges to which the vertex is incident.
        /// </remarks>
        /// <param name="vertex">The vertex.</param>
        /// <returns>
        /// True if the vertex and all edges to which it was incident were,
        /// successfully removed, false if no such vertex was found in the
        /// graph.
        /// </returns>
        bool TryRemoveVertex(V vertex);

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
        /// True if the edge was successfully added (the definition of
        /// "success" may vary from implementation to implementation).
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown if the edge contains at least one edge not in the graph,
        /// and allowNewVertices is set to false.
        /// </exception>
        bool TryAddEdge(E edge, bool allowNewVertices = false);

        /// <summary>
        /// Attempts to remove an edge from the graph.
        /// </summary>
        /// <param name="edge">The edge.</param>
        /// <returns>
        /// True if the edge was successfully removed, false otherwise.
        /// </returns>
        bool TryRemoveEdge(E edge);
    }
}
