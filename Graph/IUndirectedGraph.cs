using System;

using Graph.Exceptions;

namespace Graph
{
    /// <summary>
    /// Represents an undirected, labeled graph.
    /// </summary>
    public interface IUndirectedGraph<V, W> : IGraph<V, W>
        where V : struct, IEquatable<V>
        where W : struct, IComparable<W>, IEquatable<W>
    {
        /// <summary>
        /// Attempts to add an undirected edge to the graph.
        /// </summary>
        /// <param name="vertex1">The first vertex.</param>
        /// <param name="vertex2">The second vertex.</param>
        /// <param name="allowNewVertices"></param>
        /// <returns>
        /// True if the edge was successfully added, false if it already existed.
        /// </returns>
        /// <exception cref="VertexNotFoundException">
        /// Thrown if at least one vertex was not already in the graph, and
        /// allowNewVertices was set to false.
        /// </exception>
        bool TryAddEdge(V vertex1, V vertex2, bool allowNewVertices = false);

        /// <summary>
        /// Attempts to remove an edge from the graph.
        /// </summary>
        /// <param name="vertex1">The first vertex of the edge.</param>
        /// <param name="vertex2">The second vertex of the edge.</param>
        /// <returns>
        /// True if and only if the edge was successfully removed.
        /// </returns>
        /// <exception cref="VertexNotFoundException">
        /// Thrown if at least one of the vertices was not found in the graph.
        /// </exception>
        bool TryRemoveEdge(V vertex1, V vertex2);
    }
}
