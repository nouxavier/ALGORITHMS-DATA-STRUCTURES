using System;
using Algorithms;
using ExpectedObjects;

namespace Algorithms.Test
{
    public class GraphTest
    {
        public GraphTest()
        {
        }

        [Fact]
        public void GraphTest1()
        {
            Graphs g = new Graphs(4);

            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);

        }
    }
}

