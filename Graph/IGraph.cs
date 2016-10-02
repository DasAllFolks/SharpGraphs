using System;

namespace Graph
{
    /// <summary>
    /// Represents a graph.
    /// </summary>
    /// <typeparam name="V">The vertex type.</typeparam>
    /// <typeparam name="E">The edge type.</typeparam>
    public interface IGraph<V, E> : IEquatable<IGraph<V, E>> where E: IEdge<V>
    {
    }
}
