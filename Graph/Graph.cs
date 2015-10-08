using System;
using System.Collections.Generic;

namespace Graph
{
	public class Vertex
	{
		private bool hasLabel;
		private string label;

		public Vertex ()
		{
			this.hasLabel = false;
		}

		public Vertex (string label)
		{
			this.label = label;
			this.hasLabel = true;
		}

		// XXXX: Remind self how to link to private field?
		public bool HasLabel
		{
			get;
			set;
		}

		public string Label
		{
			get
			{
				if (!this.hasLabel)
				{
					throw NoLabelFoundException("This vertex is unlabeled.");
				}

				return this.label;
			}
			set;
		}

		public class NoLabelFoundException : Exception
		{
		}
	}

	public class Edge
	{
		public Edge ()
		{
		}
	}

	public class Graph
	{
		private HashSet<Graph.Vertex> vertices;
		private HashSet<Graph.Edge> edges;

		public Graph ()
		{
		}

		public void AddVertex ()
		{
		}

		public void AddVertex (int label)
		{
			this.vertices.Add (new Graph.Vertex((string) label));
		}

		public void AddVertex (string label)
		{
		}

		// Add an edge using labels of existing vertices.
		public void AddDirectedEdge(string TailLabel, string HeadLabel)
		{

		}

		// Add an edge using two Vertex objects.
		public void AddUndirectedEdge(string label1, string label2)
		{
			this.AddDirectedEdge (label1, label2);
			this.AddDirectedEdge (label2, label1);
		}
}
