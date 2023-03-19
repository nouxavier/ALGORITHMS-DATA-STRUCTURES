using System;
namespace Algorithms.Search
{
    public class BinarySearch
    {
        public BinarySearch()
        {
        }

        public static int? SearchIndex(List<int> ints, int item, int begin, int end)
        {
            if(begin <= end)
            {
                var midle = (begin + end) / 2;
                if (ints[midle] == item)
                    return midle;
                if (item < ints[midle])
                    return SearchIndex(ints, item, begin, midle - 1);
                else
                    return SearchIndex(ints, item, midle +1, end);
            }

            return null;
        }
    }
}

