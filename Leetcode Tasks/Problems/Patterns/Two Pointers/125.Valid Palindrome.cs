using Leetcode_Tasks.Models;
using System;

namespace Leetcode_Tasks.Problems;
public partial class Solution
{
    public bool IsPalindrome(string s)
    {
        char[] arr = s.ToCharArray();
        for (int i = 0; i < arr.Length; i++)
        {
            if (char.IsLetterOrDigit(arr[i]))
                arr[i] = char.ToLower(arr[i]);
            else
                arr[i] = ' ';
        }
        for (int left = 0, right = arr.Length - 1; left < right;)
        {
            if (arr[left] == ' ')
            {
                left++;
                continue;
            }
            if (arr[right] == ' ')
            {
                right--;
                continue;
            }
            if (arr[left] != arr[right])
                return false;
            left++;
            right--;
        }
        return true;
    }
}