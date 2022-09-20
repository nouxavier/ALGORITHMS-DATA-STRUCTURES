using System;
using Algorithms.Exceptions;

namespace Algorithms.Arrays
{
    public class LeftRotation
    {
        public int[] Input { get; private set; }

        public List<int> LInput { get; private set; }
        const string MSG_LENGTH = "Input must be range size are 0 to 1000000";


        public LeftRotation(int[] input)
        {
            if(input.Length < 1 || input.Length > 1000000)
                throw new DomainException(MSG_LENGTH);

            Input = input;
            LInput = input.ToList();
        }


        private void Rotation()
        {
            int first = Input[0];
            int aux = 0;
            for (int i = 0; i < Input.Length-1; i++)
            {
                aux = Input[i];
                Input[i] = Input[i + 1];  
            }

            Input[Input.Length-1] = first;
        }

        public int[] Rotation(int d)
        {
            for (int i = 0; i < d ; i++)
            {
                Rotation();
            }
            return Input;
        }

        private void RotationList()
        {
            int first = LInput[0];
            int aux = 0;
            for (int i = 0; i < LInput.Count - 1; i++)
            {
                aux = LInput[i];
                LInput[i] = LInput[i + 1];
            }

            LInput[LInput.Count - 1] = first;
        }

        public List<int> RotationList(int d)
        {
            for (int i = 0; i < d; i++)
            {
                RotationList();
            }
            return LInput;
        }

        public static int[] Rotate(int[] arr, int d, int n)
        {
            int[] temp = new int[n];

            // Keepig track of the current index
            // of temp[]
            var k = 0;
            // Storing the n - d elements of
            // array arr[] to the front of temp[]
            for (int i = d; i < n; i++)
            {
                temp[k] = arr[i];
                k++;
            }

            // Storing the first d elements of array arr[]
            //  into temp
            for (int i = 0; i < d; i++)
            {
                temp[k] = arr[i];
                k++;
            }

            // Copying the elements of temp[] in arr[]
            // to get the final rotated array
            for (int i = 0; i < n; i++)
            {
                arr[i] = temp[i];
            }
            return arr;
        }

    }
}

