using System;
using Algorithms.Graph;

namespace Algorithms.Test.Graph
{
    public class ShortestReachTest
    {
        public ShortestReachTest()
        {
        }

        [Fact]
        public void GraphTest1()
        {
            List<List<int>> input = new List<List<int>>
            {
                new List<int>{1,2},
                new List<int>{1,3},
                new List<int>{3,4},
            };
            int n = 5;
            int m = 3;
            int s = 1;

            ShortestReach.BFS(n, m, input, s);
        }
        [Fact]
        public void GraphTest2()
        {
            List<List<int>> input = new List<List<int>>
            {
                new List<int>{1,2},
                new List<int>{1,3},
                new List<int>{3,4},
            };
            int n = 5;
            int m = 3;
            int s = 1;

            ShortestReach.BFS2(n, m, input, s);
        }
    }
}

