using System;
using Algorithms.Arrays;

namespace Algorithms.Test.Arrays
{
    public class SparceBuilder
    {
        public static Sparse SparseBuilder(string[] stringList, string[] queries)
        {
            return new Sparse(stringList, queries);

        }
    }
}

