/*
     leetcode : 242. Valid Anagram
     link     : https://leetcode.com/problems/valid-anagram/description/
     time     : O(n+m)
     space    : O(1)
*/
public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;
        int[] first = new int[26];
        int[] second = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            first[s[i] - 'a'] += 1;
            second[t[i] - 'a'] += 1;

        }
        for (int i = 0; i < first.Length; i++)
        {
            if (first[i] != second[i]) return false;
        }
        return true;

    }
}