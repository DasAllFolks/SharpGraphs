using System;

namespace Graph
{
    /// <summary>
    /// Abstract base class for creating edges in a labeled
    /// <see cref="IGraph{V, E, W}"/>.
    /// </summary>
    /// <typeparam name="V">
    /// The type used to create vertex (node) labels.
    /// </typeparam>
    /// <typeparam name="W">
    /// The type used for the edge weight.
    /// </typeparam>
    public abstract class AbstractEdge<V, W> : IEdge<V, W>
        where V : struct, IEquatable<V>
        where W : struct, IComparable<W>, IEquatable<W>
    {
        /// <summary>
        /// The weight of the <see cref="AbstractEdge{V, W}"/>.
        /// </summary>
        public W Weight { get; set; }
    }
}
