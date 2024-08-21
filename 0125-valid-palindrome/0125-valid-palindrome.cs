public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;

        while (left <= right)
        {
            if ((s[left] < 'A' || s[left] > 'Z') && (s[left] < 'a' || s[left] > 'z') && (s[left] < '0' || s[left] > '9'))
            {
                left++;
            }
            else if ((s[right] < 'A' || s[right] > 'Z') && (s[right] < 'a' || s[right] > 'z') && (s[right] < '0' || s[right] > '9'))
            {
                right--;
            }
            else if (s[left].ToString().ToLower() != s[right].ToString().ToLower())
            {
                return false;
            }
            else if (s[left].ToString().ToLower() == s[right].ToString().ToLower())
            {
                left++;
                right--;
            }
        }
        return true;
    }
}