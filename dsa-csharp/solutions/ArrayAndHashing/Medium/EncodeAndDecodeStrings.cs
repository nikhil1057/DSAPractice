// 271. Encode and Decode Strings
// https://leetcode.com/problems/encode-and-decode-strings/
//
// Design an algorithm to encode a list of strings to a string. The encoded
// string is then sent over the network and is decoded back to the original
// list of strings.
//
// APPROACH: Length-prefix encoding (length + delimiter + data)
//
// KEY INSIGHT: Prepend each string with its length and a '#' delimiter.
// The decoder reads the length first, then grabs exactly that many chars.
// This handles ANY content (including '#', digits, empty strings).
//
// FORMAT: "{len}#{data}{len}#{data}..."
// EXAMPLE: ["hello","world"] → "5#hello5#world"
//
// WHY IT WORKS: We never search for a delimiter inside the data.
// We read a number, skip the '#', then take exactly N characters.
//
// TIME: O(n) — n = total characters across all strings
// SPACE: O(n) — the encoded/decoded output

public class EncodeAndDecodeStrings
{
    public string Encode(IList<string> strs)
    {
        var sb = new System.Text.StringBuilder();

        foreach(string s in strs)
        {
            sb.Append(s.Length);    // Prepend length
            sb.Append('#');        // Delimiter
            sb.Append(s);          // Original string data
        }

        return sb.ToString();
    }

    public IList<string> Decode(string s)
    {
        List<string> result = new();
        int i = 0;

        while(i < s.Length)
        {
            int j = i;
            while(s[j] != '#') j++;             // Find the '#' delimiter
            int length = int.Parse(s[i..j]);    // Extract length (digits before '#')
            result.Add(s[(j + 1)..(j + 1 + length)]);  // Grab exactly 'length' chars
            i = j + 1 + length;                 // Move pointer past this string
        }

        return result;
    }
}
