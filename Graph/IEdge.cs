using System;

namespace Graph
{
    /// <summary>
    /// Default interface for a graph edge, whether directed or undirected.
    /// </summary>
    /// <typeparam name="V">
    /// The type used to create vertex (node) labels.
    /// </typeparam>
    /// <typeparam name="W">
    /// The type used for the edge weight.
    /// </typeparam>
    public interface IEdge<V, W> : IEquatable<IEdge<V, W>>
        where V : struct, IEquatable<V>
        where W : struct, IEquatable<W>, IComparable<W>
    {
        /// <summary>
        /// The weight of the <see cref="IEdge{V, W}"/>.
        /// </summary>
        W Weight { get; set; }
    }
}
