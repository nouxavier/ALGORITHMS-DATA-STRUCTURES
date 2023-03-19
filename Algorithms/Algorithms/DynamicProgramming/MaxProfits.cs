using System;
namespace Algorithms.DynamicProgramming
{
    public class MaxProfits
    {
        public MaxProfits()
        {
        }
        /*You are given an array prices where prices[i]
         * is the price of a given stock on the ith day.
        You want to maximize your profit by choosing a single
        day to buy one stock and choosing a different day in the
        future to sell that stock.
        Return the maximum profit you can achieve from this transaction.
        If you cannot achieve any profit, return 0.*/
        public static int MaxProfit(int[] prices)
        {
            //firt get smallest number
            int minBuy = int.MaxValue;
            int maxSell = int.MaxValue;
            int maxProfit =-1;
            for(int i = 0; i < prices.Count(); i++)
            {
                bool change = false;
                if (minBuy > prices[i] && i != prices.Count()-1)
                {
                    minBuy = prices[i];
                    maxSell = prices[i];
                    change = true;
                }
                if(maxSell < prices[i] && !change)
                {
                    maxSell = prices[i];
                }
                var max = maxSell - minBuy;
                if(maxProfit < max)
                {
                    maxProfit = max;
                }
            }
            return maxProfit;
        }
    }
}

