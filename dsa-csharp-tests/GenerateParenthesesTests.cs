public class GenerateParenthesesTests
{
    [Fact]
    public void Example1()
    {
        var result = new GenerateParentheses().GenerateParenthesis(3);
        var expected = new List<string> { "((()))", "(()())", "(())()", "()(())", "()()()" };
        Assert.Equal(expected.OrderBy(x => x), result.OrderBy(x => x));
    }

    [Fact]
    public void Example2()
    {
        var result = new GenerateParentheses().GenerateParenthesis(1);
        Assert.Single(result);
        Assert.Equal("()", result[0]);
    }

    [Fact]
    public void NEquals2()
    {
        var result = new GenerateParentheses().GenerateParenthesis(2);
        Assert.Equal(2, result.Count);
    }

    [Fact]
    public void NEquals4()
    {
        var result = new GenerateParentheses().GenerateParenthesis(4);
        Assert.Equal(14, result.Count); // Catalan number C(4)
    }

    [Fact]
    public void NoDuplicates()
    {
        var result = new GenerateParentheses().GenerateParenthesis(4);
        Assert.Equal(result.Count, result.Distinct().Count());
    }

    [Fact]
    public void AllValid()
    {
        var result = new GenerateParentheses().GenerateParenthesis(3);
        foreach (var s in result)
        {
            int count = 0;
            foreach (var c in s)
            {
                count += c == '(' ? 1 : -1;
                Assert.True(count >= 0);
            }
            Assert.Equal(0, count);
        }
    }
}
