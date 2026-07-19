// 49. Group Anagrams
// https://leetcode.com/problems/group-anagrams/
//
// Given an array of strings strs, group the anagrams together. You can return
// the answer in any order. An anagram is a word or phrase formed by rearranging
// the letters of a different word or phrase, typically using all the original
// letters exactly once.
//
// APPROACH: Sorted string as HashMap key
//
// KEY INSIGHT: All anagrams sort to the same string.
// Use the sorted form as a unique key to group anagrams together.
//
// HOW IT WORKS:
// - For each string, sort its characters to get the canonical form.
// - Use sorted string as dictionary key.
// - Append the original string to its group.
//
// ALT APPROACH: Frequency array as key — O(n*k) but messier in C#.
// Sorting is O(n * k log k) but cleaner and fast enough.
//
// TIME: O(n * k log k) — n strings, k = average string length
// SPACE: O(n * k) — storing all strings in the map

public class GroupAnagrams
{
    public IList<IList<string>> GroupAnagramsSolution(string[] strs)
    {
        Dictionary<string, List<string>> groups = new();  // Maps sorted key → anagram group

        foreach(string s in strs)
        {
            char[] chars = s.ToCharArray();
            Array.Sort(chars);                             // Sort chars to get canonical form
            var key = new string(chars);                   // "eat" → "aet"

            if(!groups.ContainsKey(key))
                groups[key] = new List<string>();          // New group
            groups[key].Add(s);                            // Add string to its anagram group
        }

        List<IList<string>> result = new();

        foreach(var values in groups.Values) result.Add(values);  // Collect all groups

        return result;

    }
}
