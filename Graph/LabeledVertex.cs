namespace Graph
{
    /// <summary>
    /// Represents a vertex (node) in a <see cref="Graph"/> with a label of
    /// type T.
    /// </summary>
    /// <typeparam name="T">
    /// The type of the vertex's label.
    /// </typeparam>
    public class LabeledVertex<T> where T: struct
    {
        /// <summary>
        /// The Vertex's label.
        /// </summary>
        public T Label { get; set; }
    }
}
