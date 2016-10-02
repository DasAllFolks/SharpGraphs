namespace Graph
{
    /// <summary>
    /// Represents an undirected edge (link) in a <see cref="Graph"/> using
    /// vertex (node) labels of type T.
    /// </summary>
    /// <typeparam name="T">
    /// The type used to create vertex (node) labels.
    /// </typeparam>
    public interface IEdge<T> where T : struct
    {
        /// <summary>
        /// Returns true iff the <see cref="IEdge{T}"/> contains a given
        /// vertex.
        /// </summary>
        bool ContainsVertex(T vertex);
    }
}
