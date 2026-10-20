public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> seen = new HashSet<int>(nums);
        int longest = 0;

        foreach (int num in nums) {
            if (seen.Contains(num - 1))
                continue;   // Not a start of a sequence

            int current = num;
            int length = 1;

            while(seen.Contains(current + 1)) {
                current += 1;
                length++;
            }

            longest = Math.Max(longest, length);
        }

        return longest;
    }
}
