// 20. Valid Parentheses
// https://leetcode.com/problems/valid-parentheses/
//
// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']',
// determine if the input string is valid.
//
// An input string is valid if:
// 1. Open brackets must be closed by the same type of brackets.
// 2. Open brackets must be closed in the correct order.
// 3. Every close bracket has a corresponding open bracket of the same type.
//
// APPROACH: Use a stack. When we see an opening bracket, push it.
// When we see a closing bracket, check if the top of stack is the matching opener.
// If not, or stack is empty → invalid. At the end, stack must be empty.
//
// TIME: O(n) — single pass through the string
// SPACE: O(n) — stack can hold up to n/2 opening brackets

public class ValidParentheses
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();

        foreach (char c in s)
        {
            // If opening bracket, push onto stack
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else
            {
                // Closing bracket — stack must not be empty and top must match
                if (stack.Count == 0) return false;

                char top = stack.Pop();

                if (c == ')' && top != '(') return false;
                if (c == ']' && top != '[') return false;
                if (c == '}' && top != '{') return false;
            }
        }

        // Valid only if all opening brackets were matched
        return stack.Count == 0;
    }
}
