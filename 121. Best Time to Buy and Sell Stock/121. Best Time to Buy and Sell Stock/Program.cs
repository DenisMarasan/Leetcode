using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _121.Best_Time_to_Buy_and_Sell_Stock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prices1 = { 1, 2 };
            Console.WriteLine(MaxProfit(prices1));
            Console.ReadKey();

            int MaxProfit(int[] prices)
            {
                int maxDiff = 0;
                int minValue = prices[0];

                for (int i = 0; i < prices.Length; i++)
                {
                    var diff = prices[i] - minValue;

                    if (diff > maxDiff)
                            maxDiff = diff;

                    if (prices[i] < minValue)
                        minValue = prices[i];
                }

                return maxDiff;
             }
        }
    }
}