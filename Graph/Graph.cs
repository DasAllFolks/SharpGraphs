﻿using System;
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
			this.Label = label;
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
			set
			{
				this.label = value;
				this.hasLabel = true;
			}
		}

		public void ClearLabel ()
		{
			this.hasLabel = false;
		}

		public class NoLabelFoundException : Exception
		{
		}
	}

	public class Edge
	{
		// All Edge objects correspond to a directed (unidirectional) graph edge.
		//
		// An undirected edge should be represented using a pair of such (directed)
		// Edges.
		//
		// Under this system, loops and multigraphs are also automatically supported.
		//
		// Edges are Immutable after creation.
		private Vertex tail;
		private Vertex head;

		public Edge (Vertex tail, Vertex head)
		{
			this.tail = tail;
			this.head = head;
		}

		public Vertex Tail
		{
			get;
		}

		public Vertex Head
		{
			get;
		}
	}

	public class Graph
	{
		private HashSet<Graph.Vertex> vertices;
		private HashSet<Graph.Edge> edges;

		public Graph ()
		{
		}

		// Use 0-based labeling by default for vertices added without an explicit label.
		//
		// If the auto-generated label is already in use, keep searching upward until we find the first integer
		// not taken for this purpose.
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
