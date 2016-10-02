﻿namespace Graph
{
    /// <summary>
    /// Represents a directed edge (arrow) in a <see cref="Graph"/> using
    /// vertex (node) labels of type T.
    /// </summary>
    /// <remarks>
    /// <see cref="DirectedEdge{T}"/>s are immutable after construction.
    /// </remarks>
    /// <typeparam name="T">
    /// The type used to create vertex (node) labels.
    /// </typeparam>
    public struct DirectedEdge<T> : IDirectedEdge<T> where T : struct
    {
        /// <summary>
        /// Creates a new <see cref="DirectedEdge{T}"/> from two vertices.
        /// </summary>
        public DirectedEdge(T head, T tail)
        {
            Head = head;
            Tail = tail;
        }

        /// <summary>
        /// Returns the head (vertex) of the <see cref="DirectedEdge{T}"/>.
        /// </summary>
        public T Head { get; private set; }

        /// <summary>
        /// Returns the tail (vertex) of the <see cref="DirectedEdge{T}"/>.
        /// </summary>
        public T Tail { get; private set; }

        /// <summary>
        /// Determines whether two <see cref="IDirectedEdge{T}"/>s have the
        /// same head and tail vertices.
        /// </summary>
        public bool Equals(IDirectedEdge<T> directedEdge)
        {
            return Head.Equals(directedEdge.Head) && Tail.Equals(directedEdge.Tail);
        }
    }
}
