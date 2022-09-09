using System;
using Algorithms.Exceptions;

namespace Algorithms.StairCases
{
    public class StairCase
    {
        private readonly int _n;

        const string MSG = " n must be greater than zero.";

        public StairCase(int n)
        {
            if (n < 0)
                throw new DomainException(MSG);

            _n = n;
        }

        public string[,] ArrayStairCase()
        {
            string[,] matrix = new string[_n, _n];
            int size = _n - 1;
            int aux = 0;
            for (int i=size; i>=0; i--)
            {
                for (int j = size; j >= aux; j--)
                {
                    matrix[i, j] = "#";
                    
                }
               
                aux++;
            }

            Console.Write(matrix.ToString());
            return matrix;
        }

        public void PrintStairCase()
        {
            for (int i = _n-1; i >= 0; i--)
            {
                for (int j = 0; j < _n ; j++)
                {
                    if(j>= i)
                        Console.Write("#");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine("");
            }

           
        }
    }
}

