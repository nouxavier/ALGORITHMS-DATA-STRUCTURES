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

            Console.WriteLine("---------");
            if (begin < end)
            {
                int p;
                Console.WriteLine("Begin: {0}", begin);
                Console.WriteLine("End: {0}", end);

                p = Partition(arr, begin, end);
                Console.WriteLine("P: {0}", p);
                Console.WriteLine("Arrary: [{0}]",string.Join(", ",arr));
                Sort(arr, begin, p - 1);
                Sort(arr, p+1, end);
            }
            return (arr, _shift);

        }

        private static int Partition(List<int> ints, int begin, int end)
        {
            //last element list 
            var pivot = ints[end];
            Console.WriteLine("Pivot: {0}", pivot);
            int i = begin;
            for(int j = begin;j<end; j++)
            {
                if (ints[j] <= pivot)
                {
                    Console.WriteLine("Value:{0} <= Pivot:{1}, Posição j = {2}, " +
                        " Linha i: {3} ", ints[j], pivot, j, i);
                    var aux = ints[j];
                    ints[j] = ints[i];
                    ints[i] = aux;
                    i = i + 1;
                    Console.WriteLine("Inputs: {0}", string.Join(", ",ints));
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

