/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        int k = 0;
        var current = head;
        while (current != null)
        {
            k++;
            current = current.next;
        }

        k = (k / 2);

        current = head;
        for (int i = 0; i < k; i++)
        {
            current = current.next;
        }

        return current;
    }
}