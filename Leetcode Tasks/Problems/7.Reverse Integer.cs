using Leetcode_Tasks.Models;
using System;

namespace Leetcode_Tasks.Problems;
public partial class Solution
{
    public int Reverse(int x)
    {
        string str = x.ToString();
        bool isNegative = str[0] == '-';
        char[] arr = isNegative ? str.Substring(1).ToCharArray() : str.ToCharArray();
        Array.Reverse(arr);
        string reversedStr = new(arr);

        if (!int.TryParse(reversedStr, out int result))
            return 0;

        return isNegative ? -result : result;
    }
}