using System;
namespace Algorithms.Sort
{
    public class QuickSort2
    {
        public QuickSort2()
        {
        }

        private static int _shift;

        public static (List<int>,int) Sort(List<int> arr, int begin, int end)
        {
            if (begin == (arr.Count - 1) && end == 0)
                _shift = 0;

            if (begin < end)
            {
                int p;
                

                p = Partition(arr, begin, end);
                Sort(arr, begin, p - 1);
                Sort(arr, p+1, end);
            }
            return (arr, _shift);

        }

        private static int Partition(List<int> ints, int begin, int end)
        {
            //last element list 
            var pivot = ints[end];
            int i = begin;
            for(int j = begin;j<end; j++)
            {
                if (ints[j] <= pivot)
                {
                    var aux = ints[j];
                    ints[j] = ints[i];
                    ints[i] = aux;
                    i = i + 1;
                }
                _shift++;
            }

            var aux2 = ints[end];
            ints[end] = ints[i];
            ints[i] = aux2;

  
            return i;
        }
    }
}

