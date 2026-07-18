public class MinStackTests
{
    [Fact]
    public void Example1()
    {
        var stack = new MinStack();
        stack.Push(-2);
        stack.Push(0);
        stack.Push(-3);
        Assert.Equal(-3, stack.GetMin());
        stack.Pop();
        Assert.Equal(0, stack.Top());
        Assert.Equal(-2, stack.GetMin());
    }

    [Fact]
    public void SingleElement()
    {
        var stack = new MinStack();
        stack.Push(5);
        Assert.Equal(5, stack.Top());
        Assert.Equal(5, stack.GetMin());
    }

    [Fact]
    public void PushPopSequence()
    {
        var stack = new MinStack();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Pop();
        Assert.Equal(2, stack.Top());
        Assert.Equal(1, stack.GetMin());
    }

    [Fact]
    public void MinUpdatesAfterPop()
    {
        var stack = new MinStack();
        stack.Push(3);
        stack.Push(1);
        stack.Push(2);
        Assert.Equal(1, stack.GetMin());
        stack.Pop();
        Assert.Equal(1, stack.GetMin());
        stack.Pop();
        Assert.Equal(3, stack.GetMin());
    }

    [Fact]
    public void AllSameElements()
    {
        var stack = new MinStack();
        stack.Push(5);
        stack.Push(5);
        stack.Push(5);
        Assert.Equal(5, stack.GetMin());
        stack.Pop();
        Assert.Equal(5, stack.GetMin());
    }

    [Fact]
    public void NegativeNumbers()
    {
        var stack = new MinStack();
        stack.Push(-1);
        stack.Push(-5);
        stack.Push(-3);
        Assert.Equal(-5, stack.GetMin());
        Assert.Equal(-3, stack.Top());
    }
}
