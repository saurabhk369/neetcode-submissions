public class Solution {
    public bool hasDuplicate(int[] nums) {
        var numCounts = new HashSet<int>();

        foreach(int num in nums) {
            if (numCounts.Contains(num)) {
                return true;
            } else {
                numCounts.Add(num);
            }
        }
        return false;
    }
}