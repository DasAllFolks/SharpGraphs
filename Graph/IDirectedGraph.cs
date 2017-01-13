using System;

using Graph.Exceptions;

namespace Graph
{
    /// <summary>
    /// Represents a directed, labeled graph.
    /// </summary>
    public interface IDirectedGraph<V, W> : IGraph<V, W>
        where V : struct, IEquatable<V>
        where W : struct, IComparable<W>, IEquatable<W>
    {
        /// <summary>
        /// Attempts to add a directed edge to the graph.
        /// </summary>
        /// <param name="head">The head vertex.</param>
        /// <param name="tail">The tail vertex.</param>
        /// <param name="allowNewVertices">
        /// True if, when one or both vertices isn't yet in the graph, we
        /// should add the unrecognized vertex/vertices to the graph rather
        /// than just failing.
        /// </param>
        /// <returns>
        /// True if the edge was successfully added, false if it already existed.
        /// </returns>
        /// <exception cref="VertexNotFoundException">
        /// Thrown if at least one vertex was not already in the graph, and
        /// allowNewVertices was set to false.
        /// </exception>
        bool TryAddEdge(V head, V tail, bool allowNewVertices = false);

        /// <summary>
        /// Attempts to remove an edge from the graph.
        /// </summary>
        /// <param name="vertex1">The head vertex.</param>
        /// <param name="vertex2">The tail vertex.</param>
        /// <returns>
        /// True if and only if the edge was successfully removed.
        /// </returns>
        /// <exception cref="VertexNotFoundException">
        /// Thrown if at least one of the vertices was not found in the graph.
        /// </exception>
        bool TryRemoveEdge(V vertex1, V vertex2);
    }
}
