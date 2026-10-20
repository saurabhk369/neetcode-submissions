public class Solution {
    public bool IsPalindrome(string s) {
        for(short i = 0, j = (short)(s.Length - 1); i <= j; i++, j--) {
            // Console.WriteLine($"s[{i}]: {s[i]} | s[{j}]: {s[j]}");
            if(!char.IsLetterOrDigit(s[i])) {
                j++;
                continue;
            }
            if(!char.IsLetterOrDigit(s[j])) {
                i--;
                continue;
            }
            if(char.ToUpperInvariant(s[i]) != char.ToUpperInvariant(s[j]))
                return false;
        }
        return true;
    }
}
