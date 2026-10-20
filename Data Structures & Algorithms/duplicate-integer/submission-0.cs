public class Solution {
    public bool hasDuplicate(int[] nums) {
        var numCounts = new Dictionary<int, int>();

        foreach(int num in nums) {
            if (numCounts.TryGetValue(num, out _)) {
                return true;
            } else {
                numCounts[num] = 1;
            }
        }
        return false;
    }
}