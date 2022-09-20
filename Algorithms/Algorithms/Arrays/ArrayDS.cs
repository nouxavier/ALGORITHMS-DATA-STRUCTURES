using System;
using Algorithms.Exceptions;

namespace Algorithms.Arrays
{
    public class ArrayDS
    {
        public int[] Input { get; private set; }
        const string MSG = "Input for sum must be greater than zero";

        public ArrayDS(int[] input)
        {
            if (input.Length <= 0)
                throw new DomainException(MSG);

            Input = input;

        }

        public int[] ReverseInput()
        {
            Array.Reverse(Input);
            return Input;
        }
        public int[] ReverseInputFor()
        {
            int[] aux = new int[Input.Length];
            int j = Input.Length - 1;
            for (int i= 0; i < Input.Length; i++)
            {
                aux[j] = Input[i];
                j = j - 1;
            }
            return aux;
        }
    }
}

