using System;
using System.Reflection;

namespace Algorithms.Birthday
{
    public class Candle
    {
        public int[] Input { get; private set; }
        public List<int> InputList { get; private set; }

        public Candle(int[] input)
        {
            Input = input;
            InputList = input.ToList();
        }

        public void PrintListCandleTaller()
        {
            int max = InputList[0];
            int sum = 0;
            for (int i = 0; i <= InputList.Count-1; i++)
            {
                if (max == InputList[i])
                    sum ++;
                if(max < InputList[i])
                {
                    max = InputList[i];
                    sum = 1;
                }
                    
            }

        }
    }
}

