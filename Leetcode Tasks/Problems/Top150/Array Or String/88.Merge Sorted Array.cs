using Leetcode_Tasks.Models;

namespace Leetcode_Tasks.Top150;
public partial class Solution
{
                    //{1, 2, 3, 0, 0, 0};
                                        //{ 2, 5, 6 };
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1;
        int j = n - 1;
        int k = m + n - 1;

        // Merge in reverse order
        while (i >= 0 && j >= 0)
        {
            if (nums1[i] > nums2[j])
            {
                nums1[k] = nums1[i];
                i--;
            }
            else
            {
                nums1[k] = nums2[j];
                j--;
            }
            k--;
        }

        // If there are remaining elements in nums2
        while (j  >= 0)
        {
            nums1[k] = nums2[j];
            j--;
            k--;
        }
    }
}