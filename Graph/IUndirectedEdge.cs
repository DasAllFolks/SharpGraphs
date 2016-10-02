using System;

namespace Graph
{
    /// <summary>
    /// Represents an undirected edge (link) in a <see cref="Graph"/> using
    /// vertex (node) labels of type T.
    /// </summary>
    /// <typeparam name="T">
    /// The type used to create vertex (node) labels.
    /// </typeparam>
    public interface IUndirectedEdge<T> : IEquatable<IUndirectedEdge<T>> where T : struct
    {
        /// <summary>
        /// Returns true iff the <see cref="IUndirectedEdge{T}"/> contains a
        /// given vertex.
        /// </summary>
        bool Contains(T vertex);
    }
}
