public class Solution {
    public int FindMin(int[] nums) {
        if (nums[0] < nums[nums.Length - 1])
        {
            return nums[0];
        }

        if (nums.Length == 1)
        {
            return nums[0];
        }

        int l = 0;
        int r = nums.Length - 1;

        while (r > l + 1)
        {
            int m = l + (r - l) / 2;
            if (nums[m] < nums[l])
            {
                r = m;
            }
            if (nums[m] > nums[l])
            {
                l = m;
            }
        }
        return nums[r];
    }
}