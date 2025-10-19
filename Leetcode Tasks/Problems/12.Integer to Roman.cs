using Leetcode_Tasks.Models;
using System;

namespace Leetcode_Tasks.Problems;
public partial class Solution
{
    public string IntToRoman(int num)
    {
        string res = string.Empty;
        while (num > 0)
        {
            (string symbol, int value) = num switch
            {
                >= 1000 => ("M", 1000),
                >= 900 => ("CM", 900),
                >= 500 => ("D", 500),
                >= 400 => ("CD", 400),
                >= 100 => ("C", 100),
                >= 90 => ("XC", 90),
                >= 50 => ("L", 50),
                >= 40 => ("XL", 40),
                >= 10 => ("X", 10),
                9 => ("IX", 9),
                >= 5 => ("V", 5),
                4 => ("IV", 4),
                _ => ("I", 1)
            };

            res += symbol;
            num -= value;
        }
        return res;
    }
}