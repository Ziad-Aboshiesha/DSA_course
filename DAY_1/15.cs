
/*
     leetcode : 141. Linked List Cycle
     link     : https://leetcode.com/problems/linked-list-cycle/
     time     : O(n)
     space    : O(n)
*/
public class Solution
{
    public bool HasCycle(ListNode head)
    {
        HashSet<ListNode> visited = new HashSet<ListNode>();
        while (head != null)
        {
            if (visited.Contains(head))
            {
                return true;
            }
            else
            {
                visited.Add(head);
            }
            head = head.next;
        }
        return false;
    }
}