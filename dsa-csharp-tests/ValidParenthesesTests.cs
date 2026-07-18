public class ValidParenthesesTests
{
    [Fact]
    public void Example1()
    {
        Assert.True(new ValidParentheses().IsValid("()"));
    }

    [Fact]
    public void Example2()
    {
        Assert.True(new ValidParentheses().IsValid("()[]{}"));
    }

    [Fact]
    public void Example3()
    {
        Assert.False(new ValidParentheses().IsValid("(]"));
    }

    [Fact]
    public void NestedValid()
    {
        Assert.True(new ValidParentheses().IsValid("{[]}"));
    }

    [Fact]
    public void SingleOpen()
    {
        Assert.False(new ValidParentheses().IsValid("("));
    }

    [Fact]
    public void SingleClose()
    {
        Assert.False(new ValidParentheses().IsValid(")"));
    }

    [Fact]
    public void ComplexValid()
    {
        Assert.True(new ValidParentheses().IsValid("([{}])()"));
    }

    [Fact]
    public void WrongOrder()
    {
        Assert.False(new ValidParentheses().IsValid("([)]"));
    }
}
