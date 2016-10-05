using System;
using System.Collections.Generic;

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
        public IReadOnlyCollection<V> Vertices { get; private set; }

        /// <summary>
        /// The weight of the <see cref="AbstractEdge{V, W}"/>.
        /// </summary>
        public W Weight { get; set; }

        /// <summary>
        /// Populate the <see cref="AbstractEdge{V, W}"/>'s vertices and
        /// <see cref="Weight"/>.
        /// </summary>
        /// <param name="vertex1">
        /// The <see cref="AbstractEdge{V, W}"/>'s first vertex.
        /// </param>
        /// <param name="vertex2">
        /// The <see cref="AbstractEdge{V, W}"/>'s second vertex.
        /// </param>
        /// <param name="weight">
        /// The <see cref="AbstractEdge{V, W}"/>'s weight.
        /// </param>
        public AbstractEdge(V vertex1, V vertex2, W weight)
        {
            Vertices = new List<V> { vertex1, vertex2 };
            Weight = weight;
        }
    }
}
