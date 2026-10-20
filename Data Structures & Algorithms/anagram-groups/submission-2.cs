public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> result = new List<List<string>>();

        Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();

        foreach(string s in strs) {
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            string toFind = new string(chars);
            if(!groups.TryGetValue(toFind, out List<string> group)) {
                group = new List<string>();
                groups[toFind] = group;
            }
            group.Add(s);
        }

        return groups.Values.ToList();

        // foreach (string s in strs) {
        //     // Console.WriteLine($"Current: {s}");
        //     // PrintResult(result);
        //     bool isAdded = false;
        //     foreach(List<string> group in result) {
        //         if(IsAnagram(group[0], s)) {
        //             group.Add(s);
        //             isAdded = true;
        //             break;
        //         }
        //     }
        //     if(isAdded == false)
        //         result.Add([s]);
        // }

        // return result;
    }

    private bool IsAnagram(string s, string t) {
        Dictionary<char, int> freq = new Dictionary<char, int>(s.Length);

        foreach (char c in s) {
            freq[c] = freq.GetValueOrDefault(c) + 1;
        }

        foreach (char c in t) {
            // Console.WriteLine($"Char in {t}: {c}");
            if (freq.TryGetValue(c, out int count)) {
                // Console.WriteLine($"Count of {c} in {s}: {count}");
                if (count == 0) {
                    return false;
                }
                else if (count == 1) {
                    freq.Remove(c);
                } else {
                    freq[c] -= 1;
                }
            } else {
                return false;
            }
        }
        return freq.Count == 0;
    }

    private void PrintResult(List<List<string>> input) {
        Console.WriteLine("[");
        foreach (var list in input) {
            Console.WriteLine($"  [{String.Join(",", list)}]");
        }
        Console.WriteLine("]");
    }
}
