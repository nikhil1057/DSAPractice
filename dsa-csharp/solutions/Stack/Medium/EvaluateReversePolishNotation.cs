// 150. Evaluate Reverse Polish Notation
// https://leetcode.com/problems/evaluate-reverse-polish-notation/
//
// You are given an array of strings tokens that represents an arithmetic expression
// in Reverse Polish Notation. Evaluate the expression and return an integer that
// represents the value of the expression.
//
// Valid operators are +, -, *, /. Each operand may be an integer or another expression.
// Division between two integers truncates toward zero.
//
// CATEGORY: Stack (Medium)
//
// HINTS:
// - Use a stack. Push numbers onto it.
// - When you encounter an operator, pop two numbers, apply the operator, and push the result.
// - Be careful with division: truncate toward zero.
//
// TIME: O(n) — single pass through tokens
// SPACE: O(n) — stack space

public class EvaluateReversePolishNotation
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> newStack = new();

        for(int i = 0; i< tokens.Length; i++)
        {
            if(tokens[i] == "+" || tokens[i] == "-" || tokens[i] == "*" ||tokens[i] == "/")
            {
                int value1 = newStack.Pop();
                int value2 = newStack.Pop();
                int result = tokens[i] switch
                {
                    "+" => value1 + value2,
                    "-" => value2 - value1,
                    "*" => value1 * value2,
                    "/" => value2 / value1,  // int division already truncates in C#
                    _ => 0
                };

                newStack.Push(result);
            }
            else newStack.Push(int.Parse(tokens[i]));
        }

        return (int)newStack.Pop();

    }
}
