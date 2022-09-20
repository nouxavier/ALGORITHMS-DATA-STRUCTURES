using System;
using Algorithms.Exceptions;

namespace Algorithms.Arrays
{
    public class HourGlass
    {
        public int[,] Input { get; private set; }

        const string MSG_LENGTH = "Input must be size 6x6";

        public HourGlass(int[,] input)
        {
            if (input.GetLength(0) != 6 || input.GetLength(1) != 6)
                throw new DomainException(MSG_LENGTH);

            Input = input;

        }

        public int Sum()
        {
            int[,] aux = new int[4, 4];
            int max = Input[0, 0];
            for(int stepLine = 0; stepLine < 4; stepLine++)
            {
                int[] sum = new int[3] {0,0,0};
                for(int stepCol = 0; stepCol < 4; stepCol++)
                {
                    sum[0] = Input[stepLine, stepCol]
                        + Input[stepLine, stepCol+1]
                        + Input[stepLine, stepCol+2];

                    sum[1] = Input[stepLine + 1, stepCol+1];

                    sum[2] = Input[stepLine + 2, stepCol]
                       + Input[stepLine + 2, stepCol + 1]
                       + Input[stepLine + 2, stepCol + 2];

                    aux[stepLine, stepCol] = sum[0] + sum[1] + sum[2];
                    if (max < aux[stepLine, stepCol])
                        max = aux[stepLine, stepCol];
                 }
            }
            return max;
        }

        public static int SumList(List<List<int>> arr)
        {
            int[,] aux = new int[4, 4];
            int max = -2147483648;
            for (int stepLine = 0; stepLine < 4; stepLine++)
            {
                int[] sum = new int[3] { 0, 0, 0 };
                for (int stepCol = 0; stepCol < 4; stepCol++)
                {
                    sum[0] = arr[stepLine][stepCol]
                        + arr[stepLine][stepCol + 1]
                        + arr[stepLine][ stepCol + 2];

                    sum[1] = arr[stepLine + 1][ stepCol + 1];

                    sum[2] = arr[stepLine + 2][ stepCol]
                       + arr[stepLine + 2][ stepCol + 1]
                       + arr[stepLine + 2][ stepCol + 2];

                    aux[stepLine, stepCol] = sum[0] + sum[1] + sum[2];
                    if (max < aux[stepLine, stepCol])
                        max = aux[stepLine, stepCol];
                }
            }
            return max;
        }
    }
}

