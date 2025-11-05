using Leetcode_Tasks.Models;
using System;

namespace Leetcode_Tasks.Problems;
public partial class Solution
{
    /*  Input: s = "babad"
        Output: "bab"
    */
    public string LongestPalindrome(string s)
    {
        if(string.IsNullOrEmpty(s) || s.Length == 1)
            return s;

        char[] chars = s.ToCharArray();
        var right = 1;
        string result = string.Empty;
        for (int left = 0; left < s.Length - 2;)
        {
            if (chars[left] == chars[right])
            {
                var substring = s.Substring(left, right - left + 1);
                result = substring.Length > result.Length ? substring : result;
                right++;
            }
            if(right >= s.Length)
            {
                left++;
                right = left + 1;
            }
        }
        return result;
    }
}