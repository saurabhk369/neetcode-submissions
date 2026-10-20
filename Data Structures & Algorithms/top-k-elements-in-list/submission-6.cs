public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> freqs = new Dictionary<int, int>();

        foreach(int num in nums)
            freqs[num] = freqs.GetValueOrDefault(num) + 1;

        var buckets = new List<int>[nums.Length + 1];

        foreach(var pair in freqs) {
            int count = pair.Value;
            buckets[count] ??= new List<int>();
            buckets[count].Add(pair.Key);
        }

        List<int> result = new List<int>();
        for(int count = buckets.Length - 1;
            count >= 1 && result.Count < k;
            count--) {
                if(buckets[count] == null)
                    continue;
                
                foreach(int num in buckets[count]) {
                    result.Add(num);
                    if(result.Count == k) {
                        break;
                    }
                }
            }

        return result.ToArray();
    }
}
