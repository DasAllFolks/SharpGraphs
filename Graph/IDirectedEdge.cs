using System;

namespace Graph
{
    /// <summary>
    /// Represents a directed edge (arrow) in a <see cref="Graph"/> using
    /// vertex (node) labels of type T.
    /// </summary>
    /// <typeparam name="T">
    /// The type used to create vertex (node) labels.
    /// </typeparam>
    public interface IDirectedEdge<T> : IEquatable<IDirectedEdge<T>> where T : struct
    {
        /// <summary>
        /// Returns the head (vertex) of the <see cref="IDirectedEdge{T}"/>.
        /// </summary>
        T Head { get; }

        /// <summary>
        /// Returns the tail (vertex) of the <see cref="IDirectedEdge{T}"/>.
        /// </summary>
        T Tail { get; }
    }
}
