public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seen = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++) {
            if(seen.TryGetValue(target - nums[i], out int fIndex)) {
                return new int[] { fIndex, i };
            } else {
                seen[nums[i]] = i;
            }
        }

        return [];
    }
}
