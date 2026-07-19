// 125. Valid Palindrome
// https://leetcode.com/problems/valid-palindrome/
//
// A phrase is a palindrome if, after converting all uppercase letters into
// lowercase letters and removing all non-alphanumeric characters, it reads the
// same forward and backward. Alphanumeric characters include letters and numbers.
// Given a string s, return true if it is a palindrome, or false otherwise.
//
// APPROACH: Filter + Two Pointers from both ends
//
// KEY INSIGHT: Strip non-alphanumeric chars, lowercase everything, then
// check if it reads the same forwards and backwards using two pointers.
//
// HOW IT WORKS:
// - Build a cleaned array (only alphanumeric, lowercased).
// - Left pointer starts at 0, right at end.
// - If they ever mismatch → not a palindrome.
// - Move both inward until they meet.
//
// TIME: O(n) — one pass to filter, one pass to compare
// SPACE: O(n) — filtered array

public class ValidPalindrome
{
    public bool IsPalindrome(string s)
    {
        var arr = String.Concat(s.Where(x => char.IsLetterOrDigit(x))).ToLower().ToCharArray();  // Filter + lowercase

        int left = 0;
        int right = arr.Length - 1;

        while(left < right)
        {
            if(arr[left] != arr[right]) return false;  // Mismatch → not palindrome
            left++;
            right--;
        }

        return true;
    }
}
