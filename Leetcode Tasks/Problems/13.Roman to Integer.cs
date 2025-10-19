using Leetcode_Tasks.Models;
using System;

namespace Leetcode_Tasks.Problems;
public partial class Solution
{
    public int RomanToInt(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;

        int GetValue(char c) => c switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => 0
        };

        int total = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int current = GetValue(s[i]);
            int next = (i + 1 < s.Length) ? GetValue(s[i + 1]) : 0;

            if (current < next)
                total -= current;//Example: MCMXCIV = 1000 + 900 + 90 + 4
            else
                total += current;
        }

        return total;
    }
}