
/*
     leetcode : 121. Best Time to Buy and Sell Stock
     link     : https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description
     time     : O(n)
     space    : O(1)
*/

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int max = 0;
        int min = prices[0];
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < min)
            {
                min = prices[i];
                continue;
            }
            else
            {
                max = Math.Max(max, prices[i] - min);
            }
        }
        return max;
    }
}