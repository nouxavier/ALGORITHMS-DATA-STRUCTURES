using System;
using Algorithms.Tree;

namespace Algorithms.Test.Tree
{
    public class BreathFirstSearchTest
    {
        public BreathFirstSearchTest()
        {
        }

        [Fact]
        public void GetDistanceTest()
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

            BreathFirstSearch.BFSDistance(n, m, input, s);



        }
    }
}

