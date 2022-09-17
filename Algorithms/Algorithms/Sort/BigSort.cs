using System;
using System.Numerics;
using Algorithms.Exceptions;

namespace Algorithms.Sort
{
    public class BigSort
    {
        public string[] Input { get; private set; }
        public List<string> LInput { get; private set; }
        private readonly List<KeyValuePair<string, BigInteger>> ListInput = new List<KeyValuePair<string, BigInteger>>();
        private readonly BigInteger[] _inputInt;
        const string MSG = "Input for sum must be greater than zero";

        public BigSort(string[] input)
        {
            if(input.Length <= 0)
                throw new DomainException(MSG);

            _inputInt = new BigInteger[input.Length];
            Input = input;
            bool convert;

          
            for(int i = 0; i<= input.Length -1; i++)
            {
                convert = BigInteger.TryParse(input[i], out BigInteger value);
                if (!convert)
                    throw new DomainException(MSG);

                ListInput.Add(new KeyValuePair<string, BigInteger>(input[i], value));
            }

            LInput = Input.ToList();

        }

        public List<string> SortDescending()
        {
            int size = ListInput.Count;
            var aux = ListInput[0];
            for (int j=size-1; j > 0; j--)
            {
                BigInteger val = ListInput[j].Value;

                for (int i= 0; i <j; i++)
                {
                    BigInteger val2 = ListInput[i].Value;
                    if (val > val2)
                    {
                         aux = ListInput[i];
                        ListInput[i] = ListInput[i + 1];
                        ListInput[i + 1] = aux;
                    }
                }
            };
            return ListInput.Select(p=>p.Key).ToList();
        }

        public List<String> SortIncrese()
        {
            int size = ListInput.Count;
            var aux = ListInput[0];
            for (int j = 0; j < size - 1; j++)
            {
                BigInteger val = ListInput[j].Value;
                for (int i = size - 1; i > j; i--)
                {
                    BigInteger val2 = ListInput[i].Value;
                    if (val > val2)
                    {
                        aux = ListInput[i];
                        ListInput[i-1] = ListInput[i - 1];
                        ListInput[i] = aux;


                    }
                }
            };
            return ListInput.Select(p => p.Key).ToList();
        }

        private void MovePosition(List<KeyValuePair<string, BigInteger>> values, int i)
        {
            var aux = values[i];
            ListInput[i] = values[i+1];
            ListInput[i+1] = aux;

        }

        private List<string> Print(List<string> unsorted)
        {
            int size = unsorted.Count;
            var aux = new string[size];
            int val, val2, auxInt;
            bool convert;

            for (int i = 0; i <= size - 1; i++)
            {
                convert = int.TryParse(unsorted[i],out val);
                for (int j = i + 1; j <= size-1; j++)
                {
                    convert = int.TryParse(unsorted[i], out val2);
                    if (val > val2)
                    {
                        Console.WriteLine("{0},{1}", i, j);

                        auxInt = val;
                        unsorted[i] = val2.ToString();
                        unsorted[j] = auxInt.ToString();
                    }
                }
                aux[i] = unsorted[i];
            };
            return aux.ToList();
        }

        private List<string> BigSortCSharpL()
        {

            LInput.Sort((left, right) => {
                if (left.Length != right.Length)
                    return left.Length - right.Length;
                else
                    return string.CompareOrdinal(left, right); // left.CompareTo(right) is too slow
            });
            return LInput;

        }
        private string[] BigSortCSharp()
        {

            Array.Sort(Input,(left, right) => {
                if (left.Length != right.Length)
                    return left.Length - right.Length;
                else
                    return string.CompareOrdinal(left, right); // left.CompareTo(right) is too slow
            });
            return Input;

        }
    }
}

