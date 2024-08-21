public class Solution
{
    public void SortColors(int[] nums)
    {
        int index0 = 0;
        int index2 = nums.Length - 1;

        for (int i = 0; i <= index2;)
        {
            if (i < nums.Length && nums[i] == 2)
            {
                if (index2 != i)
                {
                    (nums[i], nums[index2]) = (nums[index2], nums[i]);
                    --index2;
                }
                else
                {
                    i++;
                    --index2;
                }
            }

            if (i < nums.Length && nums[i] == 0)
            {
                if (index0 != i)
                {
                    (nums[i], nums[index0]) = (nums[index0], nums[i]);
                    ++index0;
                }
                else
                {
                    i++;
                    index0++;
                }
            }

            if (i < nums.Length && nums[i] == 1)
            {
                i++;
            }
        }
    }
}