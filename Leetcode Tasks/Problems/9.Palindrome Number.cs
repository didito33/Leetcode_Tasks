using Leetcode_Tasks.Models;
using System;

namespace Leetcode_Tasks.Problems;
public partial class Solution
{
    public bool IsPalindrome(int x)
    {
        char[] arr = x.ToString().ToCharArray();
        for (int i = 0; i < arr.Length / 2; i++)
        {
            if (arr[i] != arr[arr.Length - 1 - i])
                return false;
        }
        return true;
    }
}