using Leetcode_Tasks.Models;

namespace Leetcode_Tasks.Top150;
public partial class Solution
{
    public int MaxProfit(int[] prices)
    {
        var maxProfit = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            for (int j = i + 1; j < prices.Length; j++)
            {
                maxProfit = Math.Max(maxProfit, prices[j] - prices[i]);
            }
        }
        return maxProfit;
    }
}