using System;
namespace Algorithms.Arrays
{
    public class ManipulationArray
    {
        public int N { get; private set;}
        public int M { get; private set; }
        public int[,] Queries { get; private set; }

        public ManipulationArray(int n, int m, int[,] queries)
        {
            N = n;
            M = m;
            Queries = queries;
        }

        public long Manipulation()
        {
            long[] aux = new long[N];
            int a, b, k;
            long max= -2147483648;

            for (int i=0; i< M; i++)
            {
                a = Queries[i, 0];
                b = Queries[i, 1];
                k = Queries[i, 2];

                for (int j =a; a<=b; a++)
                {
                    aux[a - 1] = aux[a - 1]+ k;
                    if (max < aux[a - 1])
                        max = aux[a - 1];
                }
            }
            return max;
        }
        public long ManipulationOptimized()
        {
            long[] aux = new long[N +2];
            int a, b, k;
            long max = -2147483648;
            long sum = 0;

            for (int i = 0; i < M; i++)
            {
                a = Queries[i, 0];
                b = Queries[i, 1];
                k = Queries[i, 2];

                aux[a] += k;
                aux[b+1] -=k;
                
            }

            for (int i = 0; i < aux.Length; i++)
            {
                sum += aux[i];
                max = Math.Max(max, sum);

            }
            return max;
        }
        public long ManipulationOptimizedList(int n, int m, List<List<int>> queries)
        {
            long[] aux = new long[n + 2];
            int a, b, k;
            long max = -2147483648;
            long sum = 0;

            for (int i = 0; i < m; i++)
            {
                a = Queries[i, 0];
                b = Queries[i, 1];
                k = Queries[i, 2];

                aux[a] += k;
                aux[b + 1] -= k;

            }

            for (int i = 0; i < aux.Length; i++)
            {
                sum += aux[i];
                max = Math.Max(max, sum);

            }
            return max;
        }

        public long Manipulation(int n, int m, List<List<int>> queries)
        {
            int[] aux = new int[n];
            int a, b, k;
            long max = -2147483648;

            for (int i = 0; i < m; i++)
            {
                a = queries[i][0];
                b = queries[i][1];
                k = queries[i][2];
         
                for (int j = a; a <= b; a++)
                {
                    aux[a - 1] = aux[a - 1] + k;
                    if (max < aux[a - 1])
                        max = aux[a - 1];
                }
            }
            return max;
        }
    }
}

