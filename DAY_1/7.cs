
/*
     leetcode : 704. Binary Search
     link     : https://leetcode.com/problems/binary-search/description/
     time     : O(log(n))
     space    : O(1)
*/

public class Solution
{
    
    public int Search(int[] nums, int target)
    {
        int start = 0;
        int end = nums.Length - 1;

        while (start <= end)
        {
            int mid = (start + end) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            if (nums[mid] < target)
            {
                start = mid + 1;
            }
            else if (nums[mid] > target)
            {
                end = mid - 1;
            }
        }
        return -1;
    }
}