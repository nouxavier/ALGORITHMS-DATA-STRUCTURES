using System;
namespace Algorithms.Search
{
    public class HackerlandRadioTransmitters
    {
        public HackerlandRadioTransmitters()
        {
        }

        public static int InstallRadio(List<int> x, int k)
        {
            List<int> results = new List<int>();
            

            x.Sort();
            int mid = 0;
            int install = 0;
            int end = 0;
            for(int i = 0; i<x.Count; i++)
            {
                mid = x[i] + k;
                //get local install
                while(i < x.Count && mid >= x[i])
                {
                    i++;
                    
                }

                if(i < x.Count)
                {
                    //get max distance install
                    end = x[i - 1] + k;
                    while (i < x.Count && end >= x[i])
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

