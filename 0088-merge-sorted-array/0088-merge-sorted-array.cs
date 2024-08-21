public class Solution 
{
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int i = m - 1;
        int j = n - 1;
        int lIndex = nums1.Length - 1;
        while (i >= 0 || j >= 0) {
            if (j < 0 || i >= 0 && nums1[i] > nums2[j]) {
                nums1[lIndex--] = nums1[i];
                i--;
            }
            else {
                nums1[lIndex--] = nums2[j];
                j--;
            }
        }
        if (m == 0) 
        {
            for (int k = 0; k < n; k++)
            {
                nums1[k] = nums2[k];
            }
        }
    }
}
