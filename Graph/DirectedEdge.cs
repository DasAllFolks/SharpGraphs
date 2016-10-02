namespace Graph
{
    /// <summary>
    /// Represents a directed edge (arrow) in a <see cref="Graph"/> using
    /// vertex (node) labels of type T.
    /// </summary>
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
    }
}
