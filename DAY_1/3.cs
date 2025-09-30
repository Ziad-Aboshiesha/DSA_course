

/*
     leetcode : 1. Two Sum
     link     : https://leetcode.com/problems/two-sum/description/
     time     : O(n)
     space    : O(n)
*/
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        if (nums.Length == 2)
        {
            return new int[] { 0, 1 };
        }
        Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int temp = target - nums[i];
            if (keyValuePairs.ContainsKey(temp))
            {
                return new int[] { keyValuePairs[temp], i };
            }
            keyValuePairs.TryAdd(nums[i], i);
        }
        return new int[] { 0, 0 };
    }
}