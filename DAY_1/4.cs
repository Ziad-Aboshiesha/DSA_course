/*
     leetcode : 20. Valid Parentheses
     link     : https://leetcode.com/problems/valid-parentheses/description/
     time     : O(n)
     space    : O(n)
*/
public class Solution
{
   
    public bool IsValid(string s)
    {
        if (s.Length <= 1) return false;
        Stack<char> stack = new Stack<char>();
        foreach (var item in s)
        {
            if (stack.Count == 0)
            {
                stack.Push(item);
                continue;
            }
            else
            {
                if ((int)stack.Peek() == (int)item - 1 || (int)stack.Peek() == (int)item - 2)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(item);
                }
            }
        }
        return stack.Count == 0;
    }
}