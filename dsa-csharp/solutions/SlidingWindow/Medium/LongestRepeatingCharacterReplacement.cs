// 424. Longest Repeating Character Replacement
// https://leetcode.com/problems/longest-repeating-character-replacement/
//
// You are given a string s and an integer k. You can choose any character of
// the string and change it to any other uppercase English letter. You can
// perform this operation at most k times. Return the length of the longest
// substring containing the same letter you can get after performing the above
// operations.
//
// APPROACH:
// Use a sliding window. Expand the window by moving the right pointer.
// Keep track of how many times each character appears in the window using
// a frequency array. The key insight:
//
// In any valid window, the number of characters we need to replace =
//   window_size - count_of_most_frequent_char_in_window
//
// If that number > k, the window is invalid — shrink it from the left.
// The answer is the largest valid window we ever see.
//
// Think of it like: pick the most common letter in the window and replace
// all others. If replacements needed > k, the window is too big.
//
// TIME: O(n) - each character is visited at most twice (once by right, once by left)
// SPACE: O(1) - frequency array has 26 entries (uppercase English letters)

public class LongestRepeatingCharacterReplacement
{
    public int CharacterReplacement(string s, int k)
    {
        int[] count = new int[26];  // frequency of each char in current window
        int left = 0;
        int maxFreq = 0;            // count of the most frequent char in window
        int result = 0;

        for(int right = 0; right < s.Length; right++)
        {
            // Add the new char to our window
            count[s[right] - 'A']++;

            // Update the max frequency seen in this window
            maxFreq = Math.Max(maxFreq, count[s[right] - 'A']);

            // Window size - most frequent char = chars we need to replace
            // If that exceeds k, shrink the window from the left
            while((right - left + 1) - maxFreq > k)
            {
                count[s[left] - 'A']--;
                left++;
            }

            // Update the best answer
            result = Math.Max(result, right - left + 1);
        }

        return result;
    }
}
