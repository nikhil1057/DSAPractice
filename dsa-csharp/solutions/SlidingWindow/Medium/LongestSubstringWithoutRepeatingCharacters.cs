// 3. Longest Substring Without Repeating Characters
// https://leetcode.com/problems/longest-substring-without-repeating-characters/
//
// Given a string s, find the length of the longest substring without repeating
// characters.
//
// APPROACH:
// Use a sliding window with a HashSet to track characters in the current window.
// Expand the window by moving the right pointer — if the new char isn't in
// the set, add it and update the max length. If it IS in the set, we have
// a duplicate — shrink the window from the left by removing chars until
// the duplicate is gone.
//
// Think of it like: keep growing a window of unique chars. The moment you
// see a repeat, start removing from the left until it's unique again.
//
// TIME: O(n) - each character is added and removed from the set at most once
// SPACE: O(min(n, m)) - where m is the size of the character set

public class LongestSubstringWithoutRepeatingCharacters
{
    public int LengthOfLongestSubstring(string s)
    {
        if( s == null || s == String.Empty) return 0;

        HashSet<char> set = new();     // characters currently in our window
        int currMax = 0;
        int i = 0;                     // left pointer
        int j = 0;                     // right pointer

        while(j < s.Length)
        {
            if(!set.Contains(s[j]))
            {
                // No duplicate — expand the window
                set.Add(s[j++]);
                currMax = Math.Max(currMax , j - i);  // update best length
            }
            else
            {
                // Duplicate found — shrink from left until it's gone
                set.Remove(s[i++]);
            }
        }

        return currMax;
    }
}
