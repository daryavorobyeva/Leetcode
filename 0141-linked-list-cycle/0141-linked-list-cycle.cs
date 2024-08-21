/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        int changed = 100001;

        var current = head;
        while (current != null && current.val != changed)
        {
            current.val = changed;
            current = current.next;
        }
        if (current == null)
        {
            return false;
        }
        else 
        {
            return true;
        }
    }
}