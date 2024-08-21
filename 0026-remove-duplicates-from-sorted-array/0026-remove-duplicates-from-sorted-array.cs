public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int r = 0;
        int k = 1;

        for (int l = 0; l < nums.Length - 1 && nums[l] != nums[nums.Length - 1]; l++)
        {
            while (r < nums.Length - 1 && nums[r] == nums[l])
            {
                r++;
            }
            k += 1;
            nums[l + 1] = nums[r];
        }
        return k;
    }
}