using System;
using Algorithms.StairCases;

namespace Algorithms.Test.StairCases
{
    public class StairCasesBuilder
    {
        public static StairCase NewAllPropsBuilder(int n)
        {
            return new StairCase(n);
        }
    }
}

