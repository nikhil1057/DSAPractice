public class ValidParenthesisStringTests
{
    [Fact]
    public void Example1()
    {
        Assert.True(new ValidParenthesisString().CheckValidString("()"));
    }

    [Fact]
    public void Example2()
    {
        Assert.True(new ValidParenthesisString().CheckValidString("(*)"));
    }

    [Fact]
    public void Example3()
    {
        Assert.True(new ValidParenthesisString().CheckValidString("(*))"));
    }

    [Fact]
    public void Unbalanced()
    {
        Assert.False(new ValidParenthesisString().CheckValidString("(("));
    }

    [Fact]
    public void StarAsEmpty()
    {
        Assert.True(new ValidParenthesisString().CheckValidString("*"));
    }

    [Fact]
    public void StarAsOpen()
    {
        Assert.True(new ValidParenthesisString().CheckValidString("*)"));
    }

    [Fact]
    public void ComplexInvalid()
    {
        Assert.False(new ValidParenthesisString().CheckValidString(")*("));
    }

    [Fact]
    public void AllStars()
    {
        Assert.True(new ValidParenthesisString().CheckValidString("***"));
    }
}
