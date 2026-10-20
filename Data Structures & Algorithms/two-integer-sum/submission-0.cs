public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var seenNums = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++) {
            var num = nums[i];
            if(seenNums.TryGetValue(target-num, out int index)) {
                return new int[] { index, i };
            } else {
                seenNums.Add(num, i);
            }
        }

        return new int[] {};
    }
}
