using System.Collections.Generic;

namespace Graph
{
    /// <summary>
    /// Represents an undirected edge (link) in a <see cref="Graph"/> using
    /// vertex (node) labels of type T.
    /// </summary>
    /// <remarks>
    /// Undirected <see cref="Edge{T}"/>"/>s are immutable after construction.
    /// </remarks>
    /// <typeparam name="T">
    /// The type used to create vertex (node) labels.
    /// </typeparam>
    public class Edge<T> : IEdge<T> where T : struct
    {
        /// <summary>
        /// The vertices comprising the edge.
        /// </summary>
        private readonly ISet<T> _vertices;

        /// <summary>
        /// Creates a new <see cref="Edge{T}"/> from two vertices.
        /// </summary>
        /// <remarks>
        /// The order of the vertices in the constructor is irrelevant.
        /// </remarks>
        public Edge(T vertex1, T vertex2)
        {
            // SortedSet used to beautify output for human readers.
            _vertices = new SortedSet<T> { vertex1, vertex2 };
        }

        /// <summary>
        /// Returns true iff the <see cref="Edge{T}"/> contains a given
        /// vertex.
        /// </summary>
        public bool ContainsVertex(T vertex)
        {
            return _vertices.Contains(vertex);
        }
    }
}
