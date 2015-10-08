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
			}
			set;
		}

		// XXXX: Remind self how to add message string.
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
