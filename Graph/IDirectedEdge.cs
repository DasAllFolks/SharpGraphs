using System;

namespace Graph
{
    /// <summary>
    /// Represents a directed edge (arrow) in a labeled <see cref="Graph"/>.
    /// </summary>
    /// <typeparam name="V">
    /// The type used to create vertex (node) labels.
    /// </typeparam>
    public interface IDirectedEdge<V, W> : IEdge<V, W>, IEquatable<IDirectedEdge<V, W>>
        where V : struct, IEquatable<V>
        where W : struct, IComparable<W>, IEquatable<W>
    {
        /// <summary>
        /// Returns the head (vertex) of the <see cref="IDirectedEdge{V}"/>.
        /// </summary>
        V Head { get; }

        /// <summary>
        /// Returns the tail (vertex) of the <see cref="IDirectedEdge{V}"/>.
        /// </summary>
        V Tail { get; }
    }
}
