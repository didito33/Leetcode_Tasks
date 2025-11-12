using Leetcode_Tasks.Models;

namespace Leetcode_Tasks.Problems;
public partial class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode dummyHead = new ListNode(0);
        ListNode current = dummyHead;
        int carry = 0;

        while (l1 != null || l2 != null || carry != 0)
        {
            int sum = carry;

            if (l1 != null)
            {
                sum += l1.val;
                l1 = l1.next;
            }

            if (l2 != null)
            {
                sum += l2.val;
                l2 = l2.next;
            }

            carry = sum / 10; // compute carry
            int digit = sum % 10; // current node’s value

            current.next = new ListNode(digit);
            current = current.next;
        }

        return dummyHead.next;
    }
}