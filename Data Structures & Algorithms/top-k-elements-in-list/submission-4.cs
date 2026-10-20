public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> freqs = new Dictionary<int, int>();

        foreach(int num in nums)
            freqs[num] = freqs.GetValueOrDefault(num) + 1;

        PriorityQueue<int, int> minPq = new PriorityQueue<int, int>();
        foreach (var freq in freqs) {
            minPq.Enqueue(freq.Key, freq.Value);
        }
        
        while(minPq.Count > k) {
            minPq.Dequeue();
        }
        
        return minPq.UnorderedItems
                .Select(item => item.Element)
                .ToArray();
    }
}
