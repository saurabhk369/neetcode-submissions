public class Solution {

    public string Encode(IList<string> strs) {
        // StringBuilder sb = new StringBuilder();
        string encoded = "";
        foreach(string str in strs) {
            // sb.Append(str.Length);
            encoded += str.Length;
            // sb.Append("#");
            encoded += "#";
            // sb.Append(str);
            encoded += str;
        }
        // return sb.ToString();
        return encoded;
    }

    public List<string> Decode(string s) {
        if (s == "") return [];

        List<string> result = new List<string>();

        int i = 0;
        do {
            int separator = s.IndexOf('#', i);
            int length = int.Parse(s.Substring(i, separator - i));

            i = separator + 1;
            result.Add(s.Substring(i, length));
            i += length;
        } while(i < s.Length);

        return result;
   }
}
