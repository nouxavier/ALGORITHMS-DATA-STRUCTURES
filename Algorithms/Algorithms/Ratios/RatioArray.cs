using System;
using Algorithms.Exceptions;

namespace Algorithms.Ratios
{
    public class RatioArray
    {
        public int[] Input { get; private set; }
        private List<int> InputList { get; set; }

        const string MSG = "Input for Ratio must be greater than zero";

        public RatioArray(int[] input)
        {
            if (input == null || input.Length <= 0)
                throw new DomainException(MSG);

            Input = input;
            InputList = input.ToList();
        }

        public float[] ResultRatio()
        {
            float[] result = new float[3] {0,0,0};
            int size = Input.Length;
            for (int i=0; i<= size - 1; i++)
            {
                if (Input[i] > 0)
                    result[0] = result[0] + 1;
                else if (Input[i] < 0)
                    result[1] = result[1] + 1;
                else
                    result[2] = result[2] + 1;
            }

            result[0] = ((float)Math.Round((result[0] / size), 6));
            result[1] = ((float)Math.Round((result[1] / size), 6));
            result[2] = ((float)Math.Round((result[2] / size), 6));


            return result;
        }

        public float[] ResultRatioList()
        {
            float[] result = new float[3] { 0, 0, 0 };
            int size = InputList.Count;
            for (int i = 0; i <= size - 1; i++)
            {
                if (InputList.ElementAt(i) > 0)
                    result[0] = result[0] + 1;
                else if (InputList[i] < 0)
                    result[1] = result[1] + 1;
                else 
                    result[2] = result[2] + 1;
            }

            result[0] = ((float)Math.Round((result[0] / size),6));
            result[1] = ((float)Math.Round((result[1] / size), 6));
            result[2] = ((float)Math.Round((result[2] / size), 6));


            return result;
        }
    }
}

