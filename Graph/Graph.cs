using System;

namespace Graph
{
	public class Vertex
	{
		private bool hasLabel;
		private string label;

		public Vertex ()
		{
		}

		// Remind self how to link to private field?
		public bool HasLabel
		{
			get;
			set;
		}

		public string Label
		{
			get;
			set;
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
}
