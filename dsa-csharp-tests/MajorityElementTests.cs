public class MajorityElementTests
{
    [Fact]
    public void Example1()
    {
        // [3,2,3] => 3
        Assert.Equal(3, new MajorityElement().MajorityElementSolution([3, 2, 3]));
    }

    [Fact]
    public void Example2()
    {
        // [2,2,1,1,1,2,2] => 2
        Assert.Equal(2, new MajorityElement().MajorityElementSolution([2, 2, 1, 1, 1, 2, 2]));
    }

    [Fact]
    public void SingleElement()
    {
        Assert.Equal(1, new MajorityElement().MajorityElementSolution([1]));
    }

    [Fact]
    public void TwoElements_Same()
    {
        Assert.Equal(5, new MajorityElement().MajorityElementSolution([5, 5]));
    }

    [Fact]
    public void AllSame()
    {
        Assert.Equal(7, new MajorityElement().MajorityElementSolution([7, 7, 7, 7, 7]));
    }

    [Fact]
    public void MajorityAtEnd()
    {
        // [1,2,3,3,3] => 3
        Assert.Equal(3, new MajorityElement().MajorityElementSolution([1, 2, 3, 3, 3]));
    }
}
