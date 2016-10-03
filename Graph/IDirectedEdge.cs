using System;

namespace Graph
{
    /// <summary>
    /// Represents a directed edge (arrow) in a labeled <see cref="Graph"/>.
    /// </summary>
    /// <typeparam name="V">
    /// The type used to create vertex (node) labels.
    /// </typeparam>
    public interface IDirectedEdge<V> : IEdge<V>, IEquatable<IDirectedEdge<V>>
        where V : struct, IEquatable<V>
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
