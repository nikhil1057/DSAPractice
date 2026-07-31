// 76. Minimum Window Substring
// https://leetcode.com/problems/minimum-window-substring/
//
// Given two strings s and t of lengths m and n respectively, return the minimum
// window substring of s such that every character in t (including duplicates)
// is included in the window. If there is no such substring, return the empty
// string "". The answer is guaranteed to be unique.
//
// APPROACH: Variable-size sliding window with "have" vs "need" counters.
// Expand right until window contains all of t, then shrink left to minimize.
// Track when each character's count meets its required frequency.
//
// TIME: O(m + n) where m = len(s), n = len(t)
// SPACE: O(n) for the frequency maps

public class MinimumWindowSubstring
{
    public string MinWindow(string s, string t)
    {
        if (string.IsNullOrEmpty(t)) return "";

        //STEP 1 - Build a frequency map of t
        var tWindow = new Dictionary<char, int>();
        int need = 0;

        for (int i = 0; i < t.Length; i++)
        {
            if (!tWindow.ContainsKey(t[i])) need++; //Get all Unique Chars from t
            tWindow[t[i]] = tWindow.GetValueOrDefault(t[i], 0) + 1;
        }

        //Step 2 - Initialize the sliding window
        var window = new Dictionary<char, int>();
        int have = 0;
        int minLength = int.MaxValue;
        int minStart = 0;

        //Step 3 - Take Two Pointers and Slide the Window
        int left = 0;

        for (int right = 0; right < s.Length; right++)
        {
            //EXPAND - Adding s[right] to window(freq map)
            char c = s[right];
            window[c] = window.GetValueOrDefault(c, 0) + 1;

            //IF this char just reached required count, so even if t = "aa" means a = 2, and window also has a = 2 -> have++
            //have means we have the total count of that char in this window
            if (tWindow.ContainsKey(c) && window[c] == tWindow[c]) have++;

            //STEP 4 - when have will reach equal to need
            //Let's Shrink it from left
            while (have == need)
            {
                int lengthOfSubstring = right - left + 1;
                if (lengthOfSubstring < minLength)
                {
                    minLength = lengthOfSubstring;
                    minStart = left;
                }

                //Remove it from the window
                char lc = s[left];
                //IF while shrinking we lose the character from t then we lose it from have and then we will break the loop
                if (tWindow.ContainsKey(lc) && window[lc] == tWindow[lc]) have--;
                window[lc]--; //Removing the count from freq map
                left++; //Shrinking the sliding window
            }
        }

        if (minLength == int.MaxValue) return "";
        else return s.Substring(minStart, minLength);
    }
}
