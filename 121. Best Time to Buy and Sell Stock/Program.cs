using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _121.Best_Time_to_Buy_and_Sell_Stock
{
    internal class Program
    {

        #region Description
        /*
        You are given an array prices where prices[i] is the price 
        of a given stock on the ith day.

        You want to maximize your profit by choosing a single day 
        to buy one stock and choosing a different day in the future 
        to sell that stock.

        Return the maximum profit you can achieve from this 
        transaction. If you cannot achieve any profit, return 0.
        */
        #endregion

        static void Main(string[] args)
        {
            int[] prc = { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine(MaxProfit(prc));
            Console.ReadLine();

            int MaxProfit(int[] prices)
            {
                int minPrice = int.MaxValue;
                int maxDiff = 0;

                for (int i = 0; i < prices.Length; i++)
                {
                    if (prices[i] < minPrice) 
                        minPrice = prices[i];

                    var diff = prices[i] - minPrice;

                    if (maxDiff < diff) 
                        maxDiff = diff;
                }

                return maxDiff;
            }
        }
    }
}
