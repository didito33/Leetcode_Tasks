using Leetcode_Tasks.Models;
using System;

namespace Leetcode_Tasks.Problems;
public partial class Solution
{
    /*
        Input: head = [1,2,3,4,5], k = 2
        Output: [4,5,1,2,3]

        Input: head = [0,1,2], k = 4
        Output: [2,0,1]
     */
    public ListNode RotateRight(ListNode head, int k)
    {
        //Edge case: if the list is empty or has one node, no rotation needed.
        if (head == null || head.next == null || k == 0)
            return head;

        ListNode right = head;
        ListNode left = head;

        //Step 1: Find the length of the list
        int length = 1;
        while (right.next != null)
        {
            right = right.next;
            length++;
        }

        //If k is larger than the length, reduce it using modulo
        k = k % length;
        if (k == 0)
            return head;

        //Reset `right` to head to start finding the rotation point
        right = head;

        //Step 2: Move `right` pointer k nodes ahead of `left`
        for (int i = 0; i < k; i++)
        {
            right = right.next;
        }

        // 🚶 Step 3: Move both pointers until `right` reaches the last node.
        // When `right.next == null`, `left` will be just before the new head.
        while (right.next != null)
        {
            right = right.next;// Move `right` to the end
            left = left.next;// move `left` forward
        }

        // ✂️ Step 4: Break and reconnect the list
        // `newStart` will be the new head after rotation.
        ListNode newStart = left.next;

        // Break the circulation at `left`
        left.next = null;

        // Connect the old tail to the old head
        right.next = head;

        // ✅ Step 5: Return new head
        return newStart;
    }

}