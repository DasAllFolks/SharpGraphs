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
		private HashSet<Vertex> vertices;
		private HashSet<Edge> edges;

		public Graph ()
		{
		}

		public void AddVertex ()
		{
		}

		public void AddVertex (int label)
		{
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
