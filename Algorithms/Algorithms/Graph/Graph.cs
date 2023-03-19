using System;
namespace Algorithms
{
    public class Graphs
    {
        public readonly int NumberVertices;
        private Dictionary<int, List<int>> adj;

        public Graphs(int numberVertices)
        {
            adj = new Dictionary<int, List<int>>();
            for (int i = 0; i < numberVertices; i++)
            {
                adj.Add(i, new List<int>());
            }
            NumberVertices = numberVertices;
        }

        // Function to add an edge into the graph
        public void AddEdge(int v, int w)
        {
            adj[v].Add(w);
            adj[w].Add(v);

        }

        public IEnumerable<int> Adj(int v)
        {
            return adj[v];
        }


    }

}

