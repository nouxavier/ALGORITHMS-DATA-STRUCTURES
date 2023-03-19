using System;
namespace Algorithms.Graph
{
    public class DFS
    {
        public DFS()
        {
        }
        private bool[] marked;

        public void DFSTraversal(Graphs g, int v)
        {
            marked = new bool[g.NumberVertices];
            DFSUtil(v, g);

        }

        private void DFSUtil(int v, Graphs g)
        {
            // Mark the current node as visited
            // and print it
            marked[v] = true;
            Console.Write(v + " ");

            // Recur for all the vertices
            // adjacent to this vertex
            List<int> vList = g.Adj(v).ToList();
            foreach (var n in vList)
            {
                if (!marked[n])
                    DFSUtil(n, g);
            }
        }
    }
}

