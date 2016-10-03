using System;
using System.Collections.Generic;

namespace Graph
{
    /// <summary>
    /// Implements shared functionality among both 
    /// see cref="SimpleGraph{V, E, W}"/>s and
    /// <see cref="MultiGraph{V, E, W}"/>s.
    /// </summary>
    /// <typeparam name="V">
    /// The type used to create vertex (node) labels.
    /// </typeparam>
    /// <typeparam name="E">The edge type.</typeparam>
    /// <typeparam name="W">
    /// The type used for the edge weight.
    /// </typeparam>
    public abstract class AbstractGraph<V, E, W> : IGraph<V, E, W>
        where V : struct, IEquatable<V>
        where E : IEdge<V, W>
        where W : struct, IComparable<W>, IEquatable<W>
    {
        /// <summary>
        /// The graph's vertices.
        /// </summary>
        protected readonly ISet<V> _vertices = new HashSet<V>();
    }
}
