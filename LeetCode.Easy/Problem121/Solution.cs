using System;
using System.Runtime.Serialization;

namespace LeetCode.Easy.Problem121
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0)
                return 0;

            int profit = 0;
            int maxProfit = 0;
            int price = prices[0];
            
            for (int i = 1; i < prices.Length; i++)
            {
                price = Math.Min(prices[i], price);
                profit = Math.Max(prices[i] - price, profit);

                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }
            }
            
            return maxProfit;
        }
    }
}