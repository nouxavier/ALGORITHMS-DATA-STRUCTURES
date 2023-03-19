
using System;
namespace Algorithms.Graph
{
    public class BFS
    {
        public BFS()
        {
        }
      
        private int[] distTo;
        private bool[] marked;

        public  void BFSPath(Graphs g, int s)
        {
            var q = new Queue<int>();
            distTo = new int[g.NumberVertices];
            marked = new bool[g.NumberVertices];

            for (int v = 0; v < g.NumberVertices; v++)
            {
                distTo[v] = int.MaxValue;
            }
            q.Enqueue(s);
            distTo[s] = 0;
            marked[s] = true;

            while(q.Count> 0)
            {
                //remove firt queue
                var v = q.Dequeue();
                foreach(var w in g.Adj(v))
                {
                    if (!marked[w])
                    {
                        marked[w] = true;
                        distTo[w] = distTo[v] + 6;
                        q.Enqueue(w);
                    }
                }

            }

        }

        public int DistTo(int v)
        {
            return distTo[v] == int.MaxValue ? -1 : distTo[v];
        }
    }
}

