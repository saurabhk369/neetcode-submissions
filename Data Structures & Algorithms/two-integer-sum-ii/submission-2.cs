public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int, int> numIdx = new Dictionary<int, int>();
        numIdx[numbers[0]] = 1;
        
        for(int i = 1; i < numbers.Length; i++) {
            // Console.WriteLine($"Check Dict for {target - numbers[i]}");
            if(numIdx.TryGetValue(target - numbers[i], out int firstIdx)) {
                // Console.WriteLine($"Found at {firstIdx}");
                return [firstIdx, i + 1];
            }
            numIdx[numbers[i]] = i + 1;
        }
        return [1,2];
    }
}
