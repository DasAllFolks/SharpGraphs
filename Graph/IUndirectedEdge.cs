using System;
using System.Collections.Generic;

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
        /// The vertices comprising the <see cref="IUndirectedEdge{T}"/>.
        /// </summary>
        ISet<T> Vertices { get; }
    }
}
