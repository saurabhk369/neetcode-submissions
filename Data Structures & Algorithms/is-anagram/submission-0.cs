public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) { return false; }

        var strCounts = new Dictionary<char, int>();

        foreach(char c in s) {
            if(strCounts.TryGetValue(c, out _)) {
                strCounts[c]++;
            } else {
                strCounts[c] = 1;
            }
        }

        foreach(char c in t) {
            if (strCounts.TryGetValue(c, out int cs)) {
                if(cs == 0) { return false; }
                strCounts[c]--;
            } else {
                return false;
            }
        }
        return true;
    }
}
