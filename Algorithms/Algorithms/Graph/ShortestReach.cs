using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Graph
{
    public class ShortestReach
    {
        
        public ShortestReach()
        {
        }

        public static void  BFS(int n, int m, List<List<int>> edges, int s)
        {
            Graphs g = new Graphs(n);
            foreach(var item in edges)
            {
                g.AddEdge(item[0], item[1]);
            }

            BFS bfs = new BFS();
            bfs.BFSPath(g, s);
            


        }

        public static void BFS2(int n, int m, List<List<int>> edges, int s)
        {
            GraphLinkedList g = new GraphLinkedList(n);
            foreach (var item in edges)
            {
                g.AddEdge(item[0], item[1]);
            }

            g.BFS(s);



        }


    }
}

