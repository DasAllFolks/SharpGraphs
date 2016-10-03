using System;

namespace Graph
{
    /// <summary>
    /// Represent an 
    /// </summary>
    /// <typeparam name="V">
    /// The type used to create vertex (node) labels.
    /// </typeparam>
    /// <typeparam name="W">
    /// The type used for the edge weight.
    /// </typeparam>
    public interface IWeightedEdge<V, W> : IEdge<V>
        where V : struct, IEquatable<V>
        where W : struct, IEquatable<W>
    {
    }
}
