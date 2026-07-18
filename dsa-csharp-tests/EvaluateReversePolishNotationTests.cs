public class EvaluateReversePolishNotationTests
{
    [Fact]
    public void Example1()
    {
        // ["2","1","+","3","*"] → 9
        Assert.Equal(9, new EvaluateReversePolishNotation().EvalRPN(new[] { "2", "1", "+", "3", "*" }));
    }

    [Fact]
    public void Example2()
    {
        // ["4","13","5","/","+"] → 6
        Assert.Equal(6, new EvaluateReversePolishNotation().EvalRPN(new[] { "4", "13", "5", "/", "+" }));
    }

    [Fact]
    public void Example3()
    {
        // ["10","6","9","3","+","-11","*","/","*","17","+","5","+"] → 22
        Assert.Equal(22, new EvaluateReversePolishNotation().EvalRPN(
            new[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" }));
    }

    [Fact]
    public void SingleNumber()
    {
        Assert.Equal(42, new EvaluateReversePolishNotation().EvalRPN(new[] { "42" }));
    }

    [Fact]
    public void Subtraction()
    {
        Assert.Equal(2, new EvaluateReversePolishNotation().EvalRPN(new[] { "5", "3", "-" }));
    }

    [Fact]
    public void DivisionTruncatesTowardZero()
    {
        // 7 / -3 = -2 (truncate toward zero)
        Assert.Equal(-2, new EvaluateReversePolishNotation().EvalRPN(new[] { "7", "-3", "/" }));
    }

    [Fact]
    public void NegativeResult()
    {
        Assert.Equal(-2, new EvaluateReversePolishNotation().EvalRPN(new[] { "3", "5", "-" }));
    }

    [Fact]
    public void Multiplication()
    {
        Assert.Equal(6, new EvaluateReversePolishNotation().EvalRPN(new[] { "2", "3", "*" }));
    }
}
