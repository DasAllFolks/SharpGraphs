using System;

namespace Graph
{
    /// <summary>
    /// Represents a multigraph (i.e. as opposed to a
    /// <see cref="SimpleGraph{V, E, W}"/>.
    /// </summary>
    /// <typeparam name="V">
    /// The type used to create vertex (node) labels.
    /// </typeparam>
    /// <typeparam name="E">The edge type.</typeparam>
    /// <typeparam name="W">
    /// The type used for the edge weight.
    /// </typeparam>
    public class MultiGraph<V, E, W> : IGraph<V, E, W>
        where V : struct, IEquatable<V>
        where E : IEdge<V, W>
        where W : struct, IComparable<W>, IEquatable<W>
    {
    }
}
