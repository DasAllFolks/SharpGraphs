using System;

namespace Graph
{
    /// <summary>
    /// Represents an edge (link) in a labeled <see cref="IGraph"/>.
    /// </summary>
    /// <typeparam name="V">
    /// The type used to create vertex (node) labels.
    /// </typeparam>
    /// <typeparam name="W">
    /// The type used for the edge weight.
    /// </typeparam>
    public interface IEdge<V, W>
        where V : struct, IEquatable<V>
        where W : struct, IComparable<W>, IEquatable<W>
    {
        /// <summary>
        /// The weight of the <see cref="IEdge{V, W}"/>.
        /// </summary>
        W Weight { get; set; }
    }
}
