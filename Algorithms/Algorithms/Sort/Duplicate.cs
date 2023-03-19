using System;
namespace Algorithms.Sort
{
    public class Duplicate
    {
        public Duplicate()
        {
        }
        private static int duplicate;

        public static int SearchDuplicate(int[] arr, int begin, int end)
        {

            if(begin < end)
            {
                int p;
                p = Partition(arr, begin, end);

                SearchDuplicate(arr, begin, p - 1);
                SearchDuplicate(arr, p + 1, end);
            }
            return duplicate;

        }
   

        private static int Partition(int[] ints, int begin, int end)
        {
            //last element list 
            var pivot = ints[end];
            int i = begin;

            for (int j = begin; j < end; j++)
            {
                if (ints[j] == pivot)
                    duplicate = pivot;

                if (ints[j] <= pivot)
                {
                    var aux = ints[j];
                    ints[j] = ints[i];
                    ints[i] = aux;
                    i = i + 1;
                }
            }

            var aux2 = ints[end];
            ints[end] = ints[i];
            ints[i] = aux2;


            return i;
        }
        private static int? SearchIndex(int[] ints, int item, int begin, int end)
        {
            if (begin <= end)
            {
                var midle = (begin + end) / 2;
                if (ints[midle] == item)
                    return midle;
                if (item < ints[midle])
                    return SearchIndex(ints, item, begin, midle - 1);
                else
                    return SearchIndex(ints, item, midle - 1, end);
            }

            return null;
        }
    }
}

