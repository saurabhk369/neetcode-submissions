public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> counts = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++) {
            if(counts.ContainsKey(s[i]))
                counts[s[i]]++;
            else
                counts[s[i]] = 1;
        }

        for (int i = 0; i < t.Length; i++) {
            if(counts.ContainsKey(t[i])) {
                counts[t[i]]--;
                if(counts[t[i]] <= 0) {
                    counts.Remove(t[i]);
                }
            } else {
                return false;
            }
        }
        return counts.Keys.Count == 0;
    }
}
