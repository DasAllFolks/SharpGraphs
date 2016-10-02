using System.Collections.Generic;

namespace Graph
{
    /// <summary>
    /// Represents an undirected edge (link) in a <see cref="Graph"/> using
    /// vertex (node) labels of type T.
    /// </summary>
    /// <remarks>
    /// <see cref="UndirectedEdge{T}"/>s are immutable after construction.
    /// </remarks>
    /// <typeparam name="T">
    /// The type used to create vertex (node) labels.
    /// </typeparam>
    public struct UndirectedEdge<T> : IUndirectedEdge<T> where T : struct
    {
        /// <summary>
        /// The vertices comprising the edge.
        /// </summary>
        public ISet<T> Vertices { get; private set; }

        /// <summary>
        /// Creates a new <see cref="UndirectedEdge{T}"/> from two vertices.
        /// </summary>
        /// <remarks>
        /// The order of the vertices in the constructor is irrelevant.
        /// </remarks>
        public UndirectedEdge(T vertex1, T vertex2)
        {
            // SortedSet used to beautify output for readers.
            Vertices = new SortedSet<T> { vertex1, vertex2 };
        }

        /// <summary>
        /// Determines whether two <see cref="IUndirectedEdge{T}"/>s consist
        /// of the same vertices.
        /// </summary>
        /// <param name="undirectedEdge"></param>
        /// <returns></returns>
        public bool Equals(IUndirectedEdge<T> undirectedEdge)
        {
            return Vertices.Equals(undirectedEdge.Vertices);
        }
    }
}
