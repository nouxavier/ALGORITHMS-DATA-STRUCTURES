using System;
using Algorithms.Exceptions;

namespace Algorithms.Sort
{
    public class IndexSort
    {
        public int[] Input { get; private set; }
        const string MSG = "Input for sum must be greater than zero";

        public IndexSort(int[] input)
        {
            if (input.Length <= 0)
                throw new DomainException(MSG);

            Input = input;
        }

        public int[] GetIndex(int n)
        {
            Array.Sort(Input);
            var index = Input.Select(p => p = n).ToList();
            return null;
        }
    }
}

