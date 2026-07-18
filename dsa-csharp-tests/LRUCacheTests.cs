public class LRUCacheTests
{
    [Fact]
    public void Example1()
    {
        var cache = new LRUCache(2);
        cache.Put(1, 1);
        cache.Put(2, 2);
        Assert.Equal(1, cache.Get(1));
        cache.Put(3, 3); // evicts key 2
        Assert.Equal(-1, cache.Get(2));
        cache.Put(4, 4); // evicts key 1
        Assert.Equal(-1, cache.Get(1));
        Assert.Equal(3, cache.Get(3));
        Assert.Equal(4, cache.Get(4));
    }

    [Fact]
    public void GetNonexistent()
    {
        var cache = new LRUCache(2);
        Assert.Equal(-1, cache.Get(1));
    }

    [Fact]
    public void UpdateExistingKey()
    {
        var cache = new LRUCache(2);
        cache.Put(1, 1);
        cache.Put(1, 10);
        Assert.Equal(10, cache.Get(1));
    }

    [Fact]
    public void CapacityOne()
    {
        var cache = new LRUCache(1);
        cache.Put(1, 1);
        cache.Put(2, 2);
        Assert.Equal(-1, cache.Get(1));
        Assert.Equal(2, cache.Get(2));
    }

    [Fact]
    public void GetRefreshesUsage()
    {
        var cache = new LRUCache(2);
        cache.Put(1, 1);
        cache.Put(2, 2);
        cache.Get(1); // refreshes key 1
        cache.Put(3, 3); // should evict key 2
        Assert.Equal(-1, cache.Get(2));
        Assert.Equal(1, cache.Get(1));
    }

    [Fact]
    public void PutRefreshesUsage()
    {
        var cache = new LRUCache(2);
        cache.Put(1, 1);
        cache.Put(2, 2);
        cache.Put(1, 10); // refreshes key 1
        cache.Put(3, 3); // should evict key 2
        Assert.Equal(-1, cache.Get(2));
        Assert.Equal(10, cache.Get(1));
    }

    [Fact]
    public void LargerCapacity()
    {
        var cache = new LRUCache(3);
        cache.Put(1, 1);
        cache.Put(2, 2);
        cache.Put(3, 3);
        cache.Put(4, 4); // evicts key 1
        Assert.Equal(-1, cache.Get(1));
        Assert.Equal(2, cache.Get(2));
        Assert.Equal(3, cache.Get(3));
        Assert.Equal(4, cache.Get(4));
    }
}
