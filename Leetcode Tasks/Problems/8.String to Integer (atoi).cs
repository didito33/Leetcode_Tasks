using Leetcode_Tasks.Models;
using System;

namespace Leetcode_Tasks.Problems;
public partial class Solution
{
    public static int MyAtoi(string s)
    {
        s = s.Trim();
        if (string.IsNullOrEmpty(s))
            return 0;

        int i = 0;
        bool isNegative = false;
        if (s[i] == '-' || s[i] == '+')
        {
            isNegative = s[i] == '-';
            i++;
        }

        List<char> digits = new List<char>();

        while (i < s.Length && char.IsDigit(s[i]))
        {
            digits.Add(s[i]);
            i++;
        }

        if (digits.Count == 0)
            return 0;

        static int ConvertToInt(List<char> charList, bool isNegative)
        {
            string str = new string(charList.ToArray());
            try
            {
                int value = int.Parse(str);
                return isNegative ? -value : value;
            }
            catch (OverflowException)
            {
                return isNegative ? int.MinValue : int.MaxValue;
            }
        }

        return ConvertToInt(digits, isNegative);
    }
}