// 121. Best Time to Buy and Sell Stock
// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
//
// You are given an array prices where prices[i] is the price of a given stock
// on the ith day. You want to maximize your profit by choosing a single day to
// buy and a single day to sell in the future. Return the maximum profit you can
// achieve. If you cannot achieve any profit, return 0.
//
// APPROACH:
// TODO: Describe your approach here
//
// TIME: O(?)
// SPACE: O(?)

public class BestTimeToBuyAndSellStock
{
    public int MaxProfit(int[] prices)
    {
        int maxPro = 0;
        int min = int.MaxValue;

        for(int i = 0; i < prices.Length; i++)
        {
            if(prices[i] < min) min = prices[i];
            maxPro = Math.Max(prices[i] - min, maxPro);
        }

        return maxPro;
    }
}
