public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new();
        foreach(string str in strs) {
            sb.Append(str.Length);
            sb.Append("#");
            sb.Append(str);
        }
        Console.WriteLine(sb.ToString());
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int i = 0;
        while (i < s.Length)
        {
            int separator = s.IndexOf('#', i);
            int length = int.Parse(s.Substring(i, separator - i));

            i = separator + 1;
            result.Add(s.Substring(i, length));
            i += length;
        }

        return result;
   }
}
