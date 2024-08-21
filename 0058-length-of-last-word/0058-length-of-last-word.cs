public class Solution {
    public int LengthOfLastWord(string s) {
        int k = 0;
        
        int index = s.Length - 1;
        while (s[index] == ' ')
        {
            index--;
        }

        while (index >= 0 && s[index] != ' ')
        {
            k++;
            index--;
        }

        return k;
    }
}