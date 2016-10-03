using System;

namespace Graph
{
    /// <summary>
    /// Represents a directed edge (arrow) in a labeled <see cref="IGraph"/>.
    /// </summary>
    /// <typeparam name="V">
    /// The type used to create vertex (node) labels.
    /// </typeparam>
    /// <typeparam name="W">
    /// The type used for the edge weight.
    /// </typeparam>
    public class DirectedEdge<V, W> : IDirectedEdge<V, W>
        where V : struct, IEquatable<V>
        where W : struct, IComparable<W>, IEquatable<W>
    {
        /// <summary>
        /// Returns the head (vertex) of the <see cref="DirectedEdge{V, W}"/>.
        /// </summary>
        /// <remarks>Immutable after construction.</remarks>
        public V Head { get; private set; }

        /// <summary>
        /// Returns the tail (vertex) of the <see cref="DirectedEdge{T}"/>.
        /// </summary>
        /// <remarks>Immutable after construction.</remarks>
        public V Tail { get; private set; }

        /// <summary>
        /// The weight of the <see cref="DirectedEdge{V, W}"/>.
        /// </summary>
        public W Weight { get; set; }

        /// <summary>
        /// Creates a new <see cref="DirectedEdge{T}"/> from two vertices.
        /// </summary>
        public DirectedEdge(V head, V tail, W weight)
        {
            Head = head;
            Tail = tail;
            Weight = weight;
        }

        /// <summary>
        /// Determines whether two <see cref="DirectedEdge{V, W}"/>s have the
        /// same head and tail vertices and weight.
        /// </summary>
        public bool Equals(IDirectedEdge<V, W> directedEdge)
        {
            return Head.Equals(directedEdge.Head) &&
                Tail.Equals(directedEdge.Tail) &&
                Weight.Equals(directedEdge.Weight);
        }
    }
}
