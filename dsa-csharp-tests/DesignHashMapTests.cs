public class DesignHashMapTests
{
    [Fact]
    public void Example1()
    {
        var hm = new MyHashMap();
        hm.Put(1, 1);
        hm.Put(2, 2);
        Assert.Equal(1, hm.Get(1));
        Assert.Equal(-1, hm.Get(3));
        hm.Put(2, 1);
        Assert.Equal(1, hm.Get(2));
        hm.Remove(2);
        Assert.Equal(-1, hm.Get(2));
    }

    [Fact]
    public void GetNonexistent()
    {
        var hm = new MyHashMap();
        Assert.Equal(-1, hm.Get(99));
    }

    [Fact]
    public void UpdateValue()
    {
        var hm = new MyHashMap();
        hm.Put(1, 10);
        hm.Put(1, 20);
        Assert.Equal(20, hm.Get(1));
    }

    [Fact]
    public void RemoveNonexistent()
    {
        var hm = new MyHashMap();
        hm.Remove(5);
        Assert.Equal(-1, hm.Get(5));
    }

    [Fact]
    public void LargeKey()
    {
        var hm = new MyHashMap();
        hm.Put(1000000, 42);
        Assert.Equal(42, hm.Get(1000000));
    }

    [Fact]
    public void MultipleKeys()
    {
        var hm = new MyHashMap();
        for (int i = 0; i < 50; i++) hm.Put(i, i * 10);
        for (int i = 0; i < 50; i++) Assert.Equal(i * 10, hm.Get(i));
        for (int i = 0; i < 50; i += 2) hm.Remove(i);
        for (int i = 0; i < 50; i += 2) Assert.Equal(-1, hm.Get(i));
        for (int i = 1; i < 50; i += 2) Assert.Equal(i * 10, hm.Get(i));
    }
}
