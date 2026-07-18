public class LetterCombinationsOfAPhoneNumberTests
{
    [Fact]
    public void Example1()
    {
        var result = new LetterCombinationsOfAPhoneNumber().LetterCombinations("23");
        var expected = new List<string> { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" };
        Assert.Equal(expected.OrderBy(x => x), result.OrderBy(x => x));
    }

    [Fact]
    public void Example2_Empty()
    {
        var result = new LetterCombinationsOfAPhoneNumber().LetterCombinations("");
        Assert.Empty(result);
    }

    [Fact]
    public void Example3_SingleDigit()
    {
        var result = new LetterCombinationsOfAPhoneNumber().LetterCombinations("2");
        var expected = new List<string> { "a", "b", "c" };
        Assert.Equal(expected.OrderBy(x => x), result.OrderBy(x => x));
    }

    [Fact]
    public void Digit7_FourLetters()
    {
        var result = new LetterCombinationsOfAPhoneNumber().LetterCombinations("7");
        Assert.Equal(4, result.Count);
    }

    [Fact]
    public void ThreeDigits()
    {
        var result = new LetterCombinationsOfAPhoneNumber().LetterCombinations("234");
        Assert.Equal(27, result.Count); // 3 * 3 * 3
    }

    [Fact]
    public void FourLetterDigits()
    {
        var result = new LetterCombinationsOfAPhoneNumber().LetterCombinations("79");
        Assert.Equal(16, result.Count); // 4 * 4
    }
}
