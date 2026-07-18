// 242. Valid Anagram
// https://leetcode.com/problems/valid-anagram/
//
// Given two strings s and t, return true if t is an anagram of s, and false
// otherwise. An anagram is a word or phrase formed by rearranging the letters
// of a different word or phrase, typically using all the original letters
// exactly once.
//
// APPROACH: HashMap frequency count (increment for s, decrement for t)
//
// KEY INSIGHT: Two strings are anagrams iff they have identical character
// frequencies. Build frequency from s, then subtract using t — if anything
// goes negative, t has a char that s doesn't (or has more of it).
//
// HOW IT WORKS:
// - Early exit if lengths differ (can't be anagrams).
// - Pass 1: Count frequency of each char in s (increment).
// - Pass 2: Decrement for each char in t. If any count < 0 → not anagram.
//
// TIME: O(n) — two passes over the strings
// SPACE: O(1) — at most 26 entries in the map (bounded by alphabet size)

public class ValidAnagram
{
    public bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length) return false;  // Different lengths → impossible

        var dict = new Dictionary<char, int>();  // Frequency map

        for(int i = 0; i < s.Length; i++)
        {
            dict[s[i]] = dict.GetValueOrDefault(s[i], 0) + 1;  // Count chars in s
        }

        for(int i = 0; i < t.Length; i++)
        {
            dict[t[i]] = dict.GetValueOrDefault(t[i], 0) - 1;  // Subtract chars in t
            if(dict [t[i]] < 0) return false;                   // t has extra char → not anagram
        }

        return true;  // All counts netted to zero
    }
}
