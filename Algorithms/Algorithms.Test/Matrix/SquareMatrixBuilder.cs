using System;
using Algorithms.Matrix;

namespace Algorithms.Test.Matrix
{
    public class SquareMatrixBuilder
    {
        public static SquareMatrix NewWithAllProps(int[,] input)
        {
            return new SquareMatrix(input);
        }
    }
}

