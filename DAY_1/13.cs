

/*
     leetcode : 35. Search Insert Position
     link     : https://leetcode.com/problems/search-insert-position/description
     time     : O(log(n))
     space    : O(1)
*/
public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int idx = 0;
        int start = 0, end = nums.Length - 1, mid;
        while (start <= end)
        {
            mid = (start + end) / 2;
            if (nums[mid] == target)
            {
                idx = mid;
                break;
            }
            else if (nums[mid] > target)
            {
                end = mid - 1;
                idx = mid;
                continue;
            }
            else
            {
                start = mid + 1;
                idx = mid + 1;
                continue;
            }
        }

        return idx;
    }
}