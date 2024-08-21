public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int index0 = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == 0 && nums[index0] == 0)
            {
                continue;
            }

            else if (nums[index0] == 0 && (nums[i] != 0))
            {
                (nums[i], nums[index0]) = (nums[index0], nums[i]);
                index0++;
            }
            
            else if (nums[index0] != 0 && nums[i] == 0)
            {
                index0 = i;
            }
        }
    }
}