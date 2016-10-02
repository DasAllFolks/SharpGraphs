namespace Graph
{
    /// <summary>
    /// Represents a vertex (node) in a <see cref="Graph"/> with a label of
    /// type T.
    /// </summary>
    /// <typeparam name="T">
    /// The type of the vertex's label.
    /// </typeparam>
    public class LabeledVertex<T>
    {
        /// <summary>
        /// The Vertex's label.
        /// </summary>
        /// <remarks>
        /// May be null to represent the absence of a label, although for a
        /// fully unlabeled Graph, you'll probably get cleaner code using
        /// <see cref=""/>.
        /// </remarks>
        public T Label { get; set; }
    }
}
