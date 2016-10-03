using System.Collections.Generic;

using System;

namespace Graph
{
    /// <summary>
    /// Represents an undirected edge (link) in a labeled <see cref="IGraph"/>.
    /// </summary>
    /// <typeparam name="V">
    /// The type used to create vertex (node) labels.
    /// </typeparam>
    public struct UndirectedEdge<V, W> : IUndirectedEdge<V, W>
        where V : struct, IEquatable<V>
        where W : struct, IComparable<W>, IEquatable<W>
    {
        /// <summary>
        /// The vertices comprising the <see cref="UndirectedEdge{V, W}"/>.
        /// </summary>
        /// <remarks>These are immutable after construction.</remarks>
        public ISet<V> Vertices { get; private set; }

        /// <summary>
        /// The weight of the <see cref="UndirectedEdge{V, W}"/>.
        /// </summary>
        public W Weight { get; set; }

        /// <summary>
        /// Creates a new <see cref="UndirectedEdge{V, W}"/> from two vertices.
        /// </summary>
        /// <remarks>
        /// The order of the vertices in the constructor is irrelevant.
        /// </remarks>
        public UndirectedEdge(V vertex1, V vertex2, W weight)
        {
            // SortedSet used to beautify output for readers.
            Vertices = new SortedSet<V> { vertex1, vertex2 };
            Weight = weight;
        }

        /// <summary>
        /// Determines whether two <see cref="IUndirectedEdge{V, W}"/>s
        /// have the same vertices and weight.
        /// </summary>
        public bool Equals(IUndirectedEdge<V, W> undirectedEdge)
        {
            return Vertices.Equals(undirectedEdge.Vertices);
        }
    }
}
