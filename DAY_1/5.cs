
/*
     leetcode : 206. Reverse Linked List
     link     : https://leetcode.com/problems/reverse-linked-list/description/
     time     : O(n)
     space    : O(1) 
*/
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        if (head == null || head.next == null) return head;
        ListNode prev = null;
        ListNode curr = head;
        while (curr != null)
        {
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        return prev;
    }

}