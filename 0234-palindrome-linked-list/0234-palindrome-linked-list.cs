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
    public bool IsPalindrome(ListNode head) {
        var fast = head;
        var slow = head;
        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }
        
        var prev = slow;
        var current = prev.next;
        slow.next = null;

        while (current != null)
        {
            var next = current.next;
            current.next = prev;

            prev = current;
            current = next;
        }

        var left = head;
        var right = prev;

        while (right != null && left.next != null)
        {
            if (left.val != right.val)
            {
                return false;
            }
            left = left.next;
            right = right.next;
        }
        return true;
    }
}