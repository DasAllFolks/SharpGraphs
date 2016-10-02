using System;

namespace Graph
{
    public interface IGraph<E, V> : IEquatable<IGraph<E, V>> where E: IEdge<V>
    {
    }
}
