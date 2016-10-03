using System;

namespace Graph
{
    /// <summary>
    /// Default interface for a graph edge, whether directed or undirected.
    /// </summary>
    /// <typeparam name="V">
    /// The type used to create vertex (node) labels.
    /// </typeparam>
    public interface IEdge<V> : IEquatable<IEdge<V>>
        where V : struct, IEquatable<V>
    {
    }
}
