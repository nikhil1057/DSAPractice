public class DesignHashSetTests
{
    [Fact]
    public void Example1()
    {
        var hs = new MyHashSet();
        hs.Add(1);
        hs.Add(2);
        Assert.True(hs.Contains(1));
        Assert.False(hs.Contains(3));
        hs.Add(2);
        Assert.True(hs.Contains(2));
        hs.Remove(2);
        Assert.False(hs.Contains(2));
    }

    [Fact]
    public void AddAndContains()
    {
        var hs = new MyHashSet();
        hs.Add(5);
        Assert.True(hs.Contains(5));
        Assert.False(hs.Contains(6));
    }

    [Fact]
    public void RemoveNonexistent()
    {
        var hs = new MyHashSet();
        hs.Remove(10);
        Assert.False(hs.Contains(10));
    }

    [Fact]
    public void AddDuplicate()
    {
        var hs = new MyHashSet();
        hs.Add(1);
        hs.Add(1);
        hs.Remove(1);
        Assert.False(hs.Contains(1));
    }

    [Fact]
    public void LargeKey()
    {
        var hs = new MyHashSet();
        hs.Add(1000000);
        Assert.True(hs.Contains(1000000));
        hs.Remove(1000000);
        Assert.False(hs.Contains(1000000));
    }

    [Fact]
    public void MultipleOperations()
    {
        var hs = new MyHashSet();
        for (int i = 0; i < 100; i++) hs.Add(i);
        for (int i = 0; i < 100; i++) Assert.True(hs.Contains(i));
        for (int i = 0; i < 100; i += 2) hs.Remove(i);
        for (int i = 0; i < 100; i += 2) Assert.False(hs.Contains(i));
        for (int i = 1; i < 100; i += 2) Assert.True(hs.Contains(i));
    }
}
