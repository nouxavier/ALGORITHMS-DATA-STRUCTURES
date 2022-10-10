using System;
namespace Algorithms.Arrays
{
    public class ArrayOfArrayProducts
    {
        public ArrayOfArrayProducts()
        {
        }
      

        public static long[]Product(int[] arr)
        {
            long[] answer = new long[arr.Length];

            if (arr.Length <= 1)
                return answer;
           
            for(int i = 0; i< arr.Length; i++)
            {
                answer[i] = 1;
                for (int j = 0; j < arr.Length; j++)
                {
                    if(j != i)
                    {
                        var teste = answer[i] * arr[j];
                        answer[i] = answer[i] * arr[j];
                    }
                }
            }

            return answer;

        }
        public static long[] ProductGood(int[] arr)
        {
            long[] repoIndexProduct = new long[arr.Length];

            if (arr.Length <= 1)
                return repoIndexProduct;

            var product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                repoIndexProduct[i] = product;
                product = product * arr[i];
                
            }
            product = 1;
            for (int i = arr.Length-1; i >=0; i--)
            {
                repoIndexProduct[i] = repoIndexProduct[i] * product;
                product = product * arr[i];

            }

            return repoIndexProduct;

        }
    }
}

