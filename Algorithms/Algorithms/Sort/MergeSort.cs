using System;
namespace Algorithms.Sort
{
    public class MergeSort
    {
        public MergeSort()
        {
        }

        public static List<int> SortCrescent(List<int> ints, int start, int end)
        {
            if(end - start > 1)
            {
                int midle = (start + end) / 2;
                var left = new List<int>();
                var right = new List<int>();

                SortCrescent(ints, start, midle);
                SortCrescent(ints, midle, end);
                MergeCrescent(ints, start, midle, end);
                
            }
            return ints;

        }

        private static List<int> MergeCrescent(List<int> ints, int start, int midle, int end)
        {
            var left = new List<int>();
            var right = new List<int>();

            for (int i = start; i < midle; i++)
            {
                left.Add(ints[i]);

            }
            for (int i = midle; i < end; i++)
            {
                right.Add(ints[i]);

            }
            int topLeft = 0;
            int topRight = 0;

            for (int i = start; i < end; i++)
            {
                if(topLeft >= left.Count)
                {
                    ints[i] = right[topRight];
                    topRight = topRight + 1;
                }
                else if (topRight >= right.Count)
                {
                    ints[i] = left[topLeft];
                    topLeft = topLeft + 1;
                }
                else if (left[topLeft] < right[topRight])
                {
                    ints[i] = left[topLeft];
                    topLeft = topLeft + 1;
                }
                else
                {
                    ints[i] = right[topRight];
                    topRight = topRight + 1;
                }
            }

            return ints;
        }
    }
}

