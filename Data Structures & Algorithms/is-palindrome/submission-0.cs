public class Solution {
    public bool IsPalindrome(string s) {
        for(int i = 0, j = s.Length - 1; i < s.Length && j >= 0; i++, j--) {
            // Console.WriteLine($"s[{i}]: {s[i]} | s[{j}]: {s[j]}");
            if(!Char.IsLetterOrDigit(s[i])) {
                j++;
                continue;
            }
            if(!Char.IsLetterOrDigit(s[j])) {
                i--;
                continue;
            }
            if(Char.ToUpperInvariant(s[i]) != Char.ToUpperInvariant(s[j]))
                return false;
        }
        return true;
    }
}
