using System;
using Algorithms.Arrays;

namespace Algorithms.Test.Arrays
{
    public class ManipulationBuilder
    {
        public static ManipulationArray NewBuilder(int n, int m, int[,] queries)
        {
            return new ManipulationArray(n,m, queries);
        }
    }
}

