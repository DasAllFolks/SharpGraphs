using System;
using System.Collections.Generic;

namespace Graph
{
    public class Graph
    {
        private HashSet<Graph.Vertex> vertices;
        private Dictionary<string, Graph.Vertex> verticesByLabel;
        private HashSet<Graph.Edge> edges;

        public Graph()
        {
        }

        // Use 0-based labeling by default for vertices added without an explicit label.
        //
        // If the auto-generated label is already in use, keep searching upward until we find the first integer
        // not taken for this purpose.
        public void AddVertex()
        {

        }

        // If vertex already exists in graph, this is no-op.
        //
        // Note that this ignores the label on the vertex if
        // it is labeled.
        public void AddUnlabeledVertex(Graph.Vertex vertex)
        {
            vertices.Add(vertex);
        }

        // If vertex already exists in graph, this is no-op.
        public void AddLabeledVertex(Graph.Vertex vertex)
        {
            vertices.Add(vertex);
            if (vertex.hasLabel)
            {
                verticesByLabel[vertex.Label] = vertex;
            }
        }

        public void AddVertex(string label)
        {
            //TODO: This currently calls the if branch every time, and
            //thus might need some optimization.
            this.AddVertex(new Graph.Vertex(label));
        }

        public void AddVertex(int label)
        {
            AddVertex((string)label);
        }

        // Add an edge using labels of existing vertices.
        public void AddDirectedEdge(string tailLabel, string headLabel)
        {

        }

        // Add an edge using two Vertex objects.
        public void AddUndirectedEdge(string label1, string label2)
        {
            AddDirectedEdge(label1, label2);
            AddDirectedEdge(label2, label1);
        }

        public void AddLoop(string label)
        {
            AddDirectedEdge(label, label);
        }

        private Graph.Vertex getVertexByLabel(string label)
        {
            try
            {
                return verticesByLabel[label];
            }
            catch (KeyNotFoundException e)
            {
                throw new VertexNotFoundException("No vertex found with label {0}", label);
            }
        }

        // Gives the number of vertices in the graph.
        public int Size
        {
            get
            {
                return vertices.Count;
            }
        }

        public class VertexNotFoundException : Exception
        {
        }
    }
}
