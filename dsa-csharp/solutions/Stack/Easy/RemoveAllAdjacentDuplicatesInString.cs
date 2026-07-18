// 1047. Remove All Adjacent Duplicates In String
// https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/
//
// You are given a string s consisting of lowercase English letters.
// A duplicate removal consists of choosing two adjacent and equal letters and removing them.
// We repeatedly make duplicate removals on s until we no longer can.
// Return the final string after all such duplicate removals have been made.
//
// CATEGORY: Stack (Easy)
//
// HINTS:
// - Use a stack. Iterate through each character.
// - If the stack is non-empty and the top equals the current char → pop (they cancel).
// - Otherwise → push the current char.
// - At the end, the stack contains the remaining characters in order.
// - Note: Stack gives reversed order, so reverse at the end (or use a List/StringBuilder).
//
// EXAMPLE:
// "abbaca" → push a, push b, b==b pop → "a", push a, a==a pop → "", push c, push a → "ca"
//
// TIME: O(n) — each character is pushed/popped at most once
// SPACE: O(n) — stack can hold up to n characters

public class RemoveAllAdjacentDuplicatesInString
{
    public string RemoveDuplicates(string s)
    {
        // TODO: Implement using a stack
        Stack<char> charStack = new Stack<char>();

        var arr = s.ToCharArray();

        Array.Reverse(arr);

        for(int i = 0; i < arr.Length; i++)
        {
            if(charStack.Count > 0 && charStack.Peek() == arr[i]) charStack.Pop();
            else charStack.Push(arr[i]);
        }

        List<char> result = new();

        while(charStack.Count() != 0)
        {
            result.Add(charStack.Pop());
        }

        return new string(result.ToArray());
    }
}
