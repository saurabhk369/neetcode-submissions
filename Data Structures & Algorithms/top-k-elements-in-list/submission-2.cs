public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        //Dictionary<int, int> freq = new Dictionary<int, int>();
        int[] freqs = new int[2010];

        foreach(int num in nums) {
            // freq[num] = freq.GetValueOrDefault(num) + 1;
            freqs[num+1001] += 1;
        }

        PriorityQueue<int, int> maxPq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        for (int i = 0; i < freqs.Length; i++) {
            maxPq.Enqueue(i, freqs[i]);
        }
        
        List<int> result = new List<int>();
        while(result.Count < k && maxPq.TryDequeue(out int index, out _)) {
            result.Add(index-1001);
        }
        
        return result.ToArray();
    }
}
