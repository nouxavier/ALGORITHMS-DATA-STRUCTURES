using System;
namespace Algorithms.Search
{
    public class HackerlandRadioTransmitters
    {
        public HackerlandRadioTransmitters()
        {
        }

        public static int InstallRadio(List<int> houses, int k)
        {
            var j = 0;
            
           
            for (var i = 1; i < houses.Count; i++)
            {
                var value = houses[i];
                j = i - 1;
                while (j >= 0 && value < houses[j])
                {
                    houses[j + 1] = houses[j];
                    j = j - 1;
                }
                houses[j + 1] = value;

            }

            
            int max = houses[houses.Count-1];
            int[] aux = new int[max];
            j = 1;
            for (int i=0; i< max; i++)
            {
                aux[i] = j;
                j++;
            }

            int mid = 0;
            int install = 0;
            int end = 0;
            List<int> aux2 = new List<int>();
            for(int i = 0; i<houses.Count; i++)
            {
                mid = houses[i] + k;
                //get local install
                while(i < houses.Count && mid >= houses[i])
                {
                    i++;
                    
                }
                aux2.Add(houses[i-1]);

                if(i < houses.Count)
                {
                    //get max distance install
                    end = houses[i - 1] + k;
                    while (i < houses.Count && end >= houses[i])
                    {
                        i++;

                    }
                    i = i - 1;
                }
                install++;
            }

            return install;
        }
    }


}

