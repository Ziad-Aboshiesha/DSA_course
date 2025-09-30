
/*
     leetcode : 1941. Check if All Characters Have Equal Number of Occurrences
     link     : https://leetcode.com/problems/check-if-all-characters-have-equal-number-of-occurrences/description/
     time     : O(n)
     space    : O(1)
*/


public class Solution
{
    public bool AreOccurrencesEqual(string s)
    {
        int[] chars = new int[26];
        int temp = 0;
        for (int i = 0; i < s.Length; i++)
        {
            chars[s[i] - 'a']++;
            temp = Math.Max(temp, chars[s[i] - 'a']);
        }
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] != 0 && chars[i] != temp)
            {
                return false;
            }
        }
        return true;
    }
}