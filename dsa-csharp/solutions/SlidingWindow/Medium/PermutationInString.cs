// 567. Permutation in String
// https://leetcode.com/problems/permutation-in-string/
//
// Given two strings s1 and s2, return true if s2 contains a permutation of s1,
// or false otherwise. In other words, return true if one of s1's permutations
// is the substring of s2.
//
// APPROACH: Fixed sliding window of size len(s1) with a "matches" counter.
// Build frequency arrays for s1 and the first window of s2, count how many of
// 26 characters have equal frequency. Slide window one char at a time, updating
// matches in O(1) per step. When matches == 26, a permutation is found.
//
// TIME: O(n) where n = len(s2)
// SPACE: O(1) — two arrays of size 26

public class PermutationInString
{
    public bool CheckInclusion(string s1, string s2)
    {
        if(s1.Length > s2.Length) return false;

        var s1_count = new int [26];
        var s2_count = new int [26];

        for(int i = 0 ; i<s1.Length; i++)
        {
            s1_count[s1[i] - 'a']++;
            s2_count[s2[i] - 'a']++;
        }

        int matches = 0;

        for(int i =0; i < s1_count.Length; i++)
        {
            if(s1_count[i] == s2_count[i]) matches++;
        }

        int left = 0;

        for(int r = s1.Length; r < s2.Length; r++)
        {
            if(matches == 26) return true;

            //Add a right Character
            int index = s2[r] - 'a'; //index of array for the new right character
            s2_count[index]++; //updated the frequency of new right character

            if(s2_count[index] == s1_count[index]) matches++;

            else if(s2_count[index] == s1_count[index] + 1) matches--; //If it does not equate now means matches dropped by one

            //Same thing for left when we remove a character

            index = s2[left] - 'a';
            s2_count[index]--; //Removing the character from window, Reducing the frequency by one

            if(s2_count[index] == s1_count[index]) matches++;

            else if(s2_count[index] == s1_count[index] - 1) matches--; //Means removing the character has made the frequencies unequal, that means it will not match

            left++;

        }

        return matches == 26;


    }
}
