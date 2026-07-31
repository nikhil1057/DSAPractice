// 155. Min Stack
// https://leetcode.com/problems/min-stack/
//
// Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.
//
// Implement the MinStack class:
// - MinStack() initializes the stack object.
// - Push(val) pushes the element val onto the stack.
// - Pop() removes the element on the top of the stack.
// - Top() gets the top element of the stack.
// - GetMin() retrieves the minimum element in the stack.
//
// You must implement a solution with O(1) time complexity for each function.
//
// CATEGORY: Stack (Medium)
//
// HINTS:
// - Use two stacks: one for values and one to track minimums.
// - Each time you push, also push the current minimum onto the min stack.
// - When you pop, pop from both stacks.
//
// TIME: O(1) for all operations
// SPACE: O(n) — for storing elements and minimums

public class MinStack
{
    private Stack<int> stack;
    private Stack<int> minStack;
    public MinStack()
    {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }

    public void Push(int val)
    {
        stack.Push(val);

        if(minStack.Count == 0 || val <= minStack.Peek()) minStack.Push(val);
    }

    public void Pop()
    {
        int val = stack.Pop();
        if(val == minStack.Peek()) minStack.Pop();
        
    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin()
    {
        return minStack.Peek();
    }
}
