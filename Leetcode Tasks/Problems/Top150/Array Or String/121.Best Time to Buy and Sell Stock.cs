using Leetcode_Tasks.Models;

namespace Leetcode_Tasks.Top150;
public partial class Solution
{
    public int MaxProfit(int[] prices)
    {
        int minPrice = int.MaxValue;
        int maxProfit = 0;

        foreach (int price in prices)
        {
            // Update minimum price seen so far
            if (price < minPrice)
                minPrice = price;

            // Calculate profit if sold today
            int profit = price - minPrice;

            // Update maximum profit
            if (profit > maxProfit)
                maxProfit = profit;
        }

        return maxProfit;
    }
}