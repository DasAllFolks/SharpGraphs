using System;
using System.Collections.Generic;

namespace Graph
{
    /// <summary>
    /// Implements shared functionality among both 
    /// see cref="SimpleGraph{V, E, W}"/>s and
    /// <see cref="MultiGraph{V, E, W}"/>s.
    /// </summary>
    /// <typeparam name="V">
    /// The type used to create vertex (node) labels.
    /// </typeparam>
    /// <typeparam name="E">The edge type.</typeparam>
    /// <typeparam name="W">
    /// The type used for the edge weight.
    /// </typeparam>
    public abstract class AbstractGraph<V, E, W> : IGraph<V, E, W>
        where V : struct, IEquatable<V>
        where E : IEdge<V, W>
        where W : struct, IComparable<W>, IEquatable<W>
    {
        /// <summary>
        /// The graph's vertices.
        /// </summary>
        protected readonly ISet<V> vertices = new HashSet<V>();

        /// <summary>
        /// Attempts to add a vertex to the graph.
        /// </summary>
        /// <param name="vertex">The vertex.</param>
        /// <returns>
        /// True if the vertex was successfully added, false if it already
        /// existed.
        /// </returns>
        public bool TryAddVertex(V vertex)
        {
            return vertices.Add(vertex);
        }

        /// <summary>
        /// Attempts to remove a vertex from the graph.
        /// </summary>
        /// <param name="vertex">The vertex.</param>
        /// <returns>
        /// True if the vertex was successfully removed, false if no such
        /// vertex was found in the graph.
        /// </returns>
        public bool TryRemoveVertex(V vertex)
        {
            return vertices.Remove(vertex);
        }

        /// <summary>
        /// Attempts to add an edge to the graph.
        /// </summary>
        /// <param name="edge">
        /// The edge.
        /// </param>
        /// <param name="allowNewVertices">
        /// Iff true, add vertices in the edge which aren't yet in the graph
        /// to the graph's vertex set.
        /// </param>
        /// <returns>
        /// True if the edge was successfully added (the definition of
        /// "success" may vary from implementation to implementation).
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown if the edge contains at least one edge not in the graph,
        /// and allowNewVertices is set to false.
        /// </exception>
        public bool TryAddEdge(E edge, bool allowNewVertices = false)
        {
            if (edge == null)
            {
                throw new ArgumentNullException();
            }

            // XXXX: Need a way to check vertices here.
            if (!allowNewVertices && !())
            {

            }

            return TryAddEdgeImpl(edge);
        }

        protected bool TryAddEdgeImpl(E edge)
        {
            throw new NotImplementedException();
        }
    }
}
