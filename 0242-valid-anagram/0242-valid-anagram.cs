public class Solution {
    public bool IsAnagram(string s, string t) {
        var s1 = s.ToArray();
        Array.Sort(s1);
        var ss = new string(s1);

        var t1 = t.ToArray();
        Array.Sort(t1);
        var tt = new string(t1);

        if (tt == ss)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}