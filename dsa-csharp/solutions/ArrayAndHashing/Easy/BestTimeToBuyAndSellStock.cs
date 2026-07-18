// 121. Best Time to Buy and Sell Stock
// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
//
// You are given an array prices where prices[i] is the price of a given stock
// on the ith day. You want to maximize your profit by choosing a single day to
// buy and a single day to sell in the future. Return the maximum profit you can
// achieve. If you cannot achieve any profit, return 0.
//
// APPROACH: Track minimum price, compute max profit greedily
//
// KEY INSIGHT: As we scan left to right, we always want to buy at the
// lowest price seen so far and sell at the current price. The best profit
// is the maximum of (current_price - min_price_so_far) across all days.
//
// HOW IT WORKS:
// - Keep track of the minimum price encountered so far.
// - At each day, calculate profit if we sold today (price - min_price).
// - Update max_profit if this is better.
// - Update min_price if current price is lower.
//
// WHY IT WORKS: We're guaranteed to buy before selling because min_price
// only considers prices from earlier days.
//
// TIME: O(n) — single pass
// SPACE: O(1) — two variables

public class BestTimeToBuyAndSellStock
{
    public int MaxProfit(int[] prices)
    {
        int maxPro = 0;            // Best profit achievable
        int min = int.MaxValue;    // Lowest price seen so far (best buy day)

        for(int i = 0; i < prices.Length; i++)
        {
            if(prices[i] < min) min = prices[i];                   // Found a cheaper buy day
            maxPro = Math.Max(prices[i] - min, maxPro);            // Check if selling today is best
        }

        return maxPro;
    }
}
