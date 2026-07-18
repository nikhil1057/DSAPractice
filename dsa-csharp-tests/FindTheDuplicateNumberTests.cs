public class FindTheDuplicateNumberTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(2, new FindTheDuplicateNumber().FindDuplicate(new[] { 1, 3, 4, 2, 2 }));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(3, new FindTheDuplicateNumber().FindDuplicate(new[] { 3, 1, 3, 4, 2 }));
    }

    [Fact]
    public void Example3()
    {
        Assert.Equal(3, new FindTheDuplicateNumber().FindDuplicate(new[] { 3, 3, 3, 3, 3 }));
    }

    [Fact]
    public void TwoElements()
    {
        Assert.Equal(1, new FindTheDuplicateNumber().FindDuplicate(new[] { 1, 1 }));
    }

    [Fact]
    public void DuplicateAtStart()
    {
        Assert.Equal(2, new FindTheDuplicateNumber().FindDuplicate(new[] { 2, 2, 1, 3, 4 }));
    }

    [Fact]
    public void DuplicateAtEnd()
    {
        Assert.Equal(4, new FindTheDuplicateNumber().FindDuplicate(new[] { 1, 2, 3, 4, 4 }));
    }

    [Fact]
    public void LargerArray()
    {
        Assert.Equal(6, new FindTheDuplicateNumber().FindDuplicate(new[] { 1, 4, 6, 2, 3, 5, 6 }));
    }
}
