using System;
using Algorithms.Exceptions;

namespace Algorithms.Matrix
{
    public class SquareMatrix
    {
        public int[,] Input { get; private set; }
        const string MSG = "Input for sum must be greater than zero";
        const string MSG2 = "Input must be square matrix";

        private int[] result= new int[] { };

        public SquareMatrix(int[,]input)
        {
            if (input == null || input.Length <= 0)
                throw new DomainException(MSG);

            if (input.GetLength(0) != input.GetLength(1))
                throw new DomainException(MSG2);

            Input = input;
        }

        public int ResultSumDiagonal()
        {
            int left = 0;
            int right = 0;
            int index = Input.GetLength(0)-1;


            for (int i = 0; i<= index; i++)
            {
                right = right + Input[i, i];
                left = left + Input[i, index - i];
            }

            int result = right - left;
            return  Math.Abs(result);
        }


        public int ResultSumDiagonal(List<List<int>> arr)
        {
            int left = 0;
            int right = 0;
            int index = arr.Count - 1;


            for (int i = 0; i <= index; i++)
            {
                right = right + arr.ElementAt(i).ElementAt(i);
                left = left + arr.ElementAt(i).ElementAt(index-i);
            }

            int result = right - left;
            return Math.Abs(result);
        }

    }
}

