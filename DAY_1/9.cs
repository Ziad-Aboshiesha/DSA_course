
/*
     leetcode : 58. Length of Last Word
     link     : https://leetcode.com/problems/length-of-last-word/description/
     time     : O(n)
     space    : O(1) note that using trim conusume more space so make it manually
*/


public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int start = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != ' ')
            {

                start = i;
                break;
            }

        }
        int count = 0;
        for (int i = start; i >= 0; i--)
        {
            if (s[i] == ' ')
            {
                break;
            }
            else
            {
                count++;
            }
        }
        return count;
    }
}