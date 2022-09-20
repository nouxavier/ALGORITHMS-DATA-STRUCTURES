using System;
using System.Reflection;
using Algorithms.Exceptions;

namespace Algorithms.Sort
{
    public class QuickSortString
    {
        public List<List<string>> Input { get; private set; }
        const string MSG = "Input for sum must be greater than zero";


        public QuickSortString(List<List<string>> input)
        {
            if (input.Count <= 0)
                throw new DomainException(MSG);

            Input = input;

          
        }
        public void Sort2()
        {
            List<List<string>> aux = new List<List<string>>();
            int index = 0;
            int half = Input.Count / 2;
            for (int i = 0; i < half; i++)
            {
                int.TryParse(Input[i].First(), out index);
                Input[index][1]= "-";
            }

           
            for (int i = half; i <= Input.Count - 1; i++)
            {
                int.TryParse(Input[i].First(), out index);
                aux[index][1] = Input[i][1];
            }

            for (int j = 0; j < aux.Count; j++)
            {
                Console.Write(aux[j][1] + " ");

            }
        }

        public void Sort(int n)
        {
            List<int> aux = new List<int>(new int[n + 1]);
            int index = 0;
            int half = Input.Count / 2;
            string max="";

            for (int i = 0; i <= Input.Count - 1; i++)
            {
                if(!int.TryParse(Input[i].First(), out index))
                    throw new DomainException(MSG);

                if (max.Length < Input[i][0].Length)
                    max = Input[i][0];
                if (i<half)
                    Input[i][1] = "-";

                aux[index] += 1;
            }
            List<List<string>> aux2 = new  List<List<string>>();

            for (int i = 0; i <= aux.Count - 1; i++)
            {
                if (aux[i] != 0)
                {
                    for(int j=0;j< Input.Count; j++)
                    {
                        if (Input[j].Contains(i.ToString()))
                        {
                            aux2.Add(Input[j]);
                            Console.Write(Input[j][1]);

                        }

                    }
                }

            }
     


        }
    }
}

