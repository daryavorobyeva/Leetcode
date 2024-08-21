public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int l = 0;
        int r = matrix.Length * matrix[0].Length - 1;

        while (r >= l)
        {
            int m = l + (r - l) / 2;
            if (matrix[m / matrix[0].Length][m % matrix[0].Length] == target)
            {
                return true;
            }
            if (matrix[m / matrix[0].Length][m % matrix[0].Length] < target)
            {
                l = m + 1;
            }
            if (matrix[m / matrix[0].Length][m % matrix[0].Length] > target)
            {
                r = m - 1;
            }
        }
        return false;
    }
}