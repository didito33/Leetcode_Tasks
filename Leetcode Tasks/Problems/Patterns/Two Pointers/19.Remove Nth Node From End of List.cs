using Leetcode_Tasks.Models;
using System;

namespace Leetcode_Tasks.Problems;
public partial class Solution
{
    /*
        input: head = [1,2,3,4,5], n = 2
        output: [1,2,3,5]
     */
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        // Step 1: Count total nodes
        ListNode tail = head;
        int nodeCount = 1;
        while (tail.next != null)
        {
            tail = tail.next;
            nodeCount++;
        }

        if (head == null || nodeCount == 1)
            return null;

        // Step 2: Handle edge case — removing the first node
        if (n == nodeCount)
        {
            return head.next;
        }

        // Step 3: Find the node *before* the one we need to remove
        ListNode current = head;
        for (int i = 1; i < nodeCount - n; i++)
        {
            current = current.next;
        }

        // Step 4: Skip the target node
        current.next = current.next.next;

        // Step 5: Return the (unchanged) head
        return head;
    }
}