public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        List<int> result = new List<int>();
        int i = 0;
        int j = 0;
        Array.Sort(nums1);
        Array.Sort(nums2);
         while (i < nums1.Length || j < nums2.Length)
         {
            if (j == nums2.Length || i < nums1.Length && nums1[i] < nums2[j])
            {
                i++;
            }

            else if (i == nums1.Length || j < nums2.Length && nums1[i] > nums2[j])
            {
                j++;
            }
            else if (nums1[i] == nums2[j])
            {
                result.Add(nums1[i]);
                i++;
                j++;
            }
         }
         return result.ToArray();
    }
}
