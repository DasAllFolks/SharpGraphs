using System;

namespace Graph
{
    /// <summary>
    /// Represents an undirected edge (link) in a labeled <see cref="IGraph"/>.
    /// </summary>
    /// <typeparam name="V">
    /// The type used to create vertex (node) labels.
    /// </typeparam>
    public class UndirectedEdge<V, W> : AbstractEdge<V, W>, IUndirectedEdge<V, W>
        where V : struct, IEquatable<V>
        where W : struct, IComparable<W>, IEquatable<W>
    {
        /// <summary>
        /// Creates a new <see cref="UndirectedEdge{V, W}"/> from two vertices.
        /// </summary>
        /// <remarks>
        /// The order of the vertices in the constructor is irrelevant.
        /// </remarks>
        public UndirectedEdge(V vertex1, V vertex2, W weight)
            : base(vertex1, vertex2, weight)
        {
        }

        /// <summary>
        /// Determines whether two <see cref="IUndirectedEdge{V, W}"/>s
        /// have the same vertices and weight.
        /// </summary>
        public bool Equals(IUndirectedEdge<V, W> undirectedEdge)
        {
            return Vertices.Equals(undirectedEdge.Vertices) &&
                Weight.Equals(undirectedEdge.Weight);
        }
    }
}
