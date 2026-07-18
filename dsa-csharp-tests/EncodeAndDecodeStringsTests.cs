public class EncodeAndDecodeStringsTests
{
    [Fact]
    public void Example1()
    {
        var codec = new EncodeAndDecodeStrings();
        var strs = new List<string> { "Hello", "World" };
        Assert.Equal(strs, codec.Decode(codec.Encode(strs)));
    }

    [Fact]
    public void EmptyString()
    {
        var codec = new EncodeAndDecodeStrings();
        var strs = new List<string> { "" };
        Assert.Equal(strs, codec.Decode(codec.Encode(strs)));
    }

    [Fact]
    public void EmptyList()
    {
        var codec = new EncodeAndDecodeStrings();
        var strs = new List<string>();
        Assert.Equal(strs, codec.Decode(codec.Encode(strs)));
    }

    [Fact]
    public void SpecialChars()
    {
        var codec = new EncodeAndDecodeStrings();
        var strs = new List<string> { "we", "say", ":", "yes" };
        Assert.Equal(strs, codec.Decode(codec.Encode(strs)));
    }

    [Fact]
    public void StringsWithNumbers()
    {
        var codec = new EncodeAndDecodeStrings();
        var strs = new List<string> { "123", "456", "789" };
        Assert.Equal(strs, codec.Decode(codec.Encode(strs)));
    }

    [Fact]
    public void MultipleEmptyStrings()
    {
        var codec = new EncodeAndDecodeStrings();
        var strs = new List<string> { "", "", "" };
        Assert.Equal(strs, codec.Decode(codec.Encode(strs)));
    }

    [Fact]
    public void StringsWithDelimiterChars()
    {
        var codec = new EncodeAndDecodeStrings();
        var strs = new List<string> { "a#b", "c#d", "#" };
        Assert.Equal(strs, codec.Decode(codec.Encode(strs)));
    }

    [Fact]
    public void SingleString()
    {
        var codec = new EncodeAndDecodeStrings();
        var strs = new List<string> { "onlyone" };
        Assert.Equal(strs, codec.Decode(codec.Encode(strs)));
    }
}
