public class TimeBasedKeyValueStoreTests
{
    [Fact]
    public void Example1()
    {
        var tm = new TimeBasedKeyValueStore();
        tm.Set("foo", "bar", 1);
        Assert.Equal("bar", tm.Get("foo", 1));
        Assert.Equal("bar", tm.Get("foo", 3));
        tm.Set("foo", "bar2", 4);
        Assert.Equal("bar2", tm.Get("foo", 4));
        Assert.Equal("bar2", tm.Get("foo", 5));
    }

    [Fact]
    public void GetBeforeAnySet()
    {
        var tm = new TimeBasedKeyValueStore();
        tm.Set("key", "val", 5);
        Assert.Equal("", tm.Get("key", 3));
    }

    [Fact]
    public void NonexistentKey()
    {
        var tm = new TimeBasedKeyValueStore();
        Assert.Equal("", tm.Get("missing", 1));
    }

    [Fact]
    public void ExactTimestamp()
    {
        var tm = new TimeBasedKeyValueStore();
        tm.Set("a", "v1", 1);
        tm.Set("a", "v2", 2);
        tm.Set("a", "v3", 3);
        Assert.Equal("v2", tm.Get("a", 2));
    }

    [Fact]
    public void BetweenTimestamps()
    {
        var tm = new TimeBasedKeyValueStore();
        tm.Set("a", "v1", 1);
        tm.Set("a", "v2", 5);
        Assert.Equal("v1", tm.Get("a", 3));
    }

    [Fact]
    public void MultipleKeys()
    {
        var tm = new TimeBasedKeyValueStore();
        tm.Set("x", "val_x", 1);
        tm.Set("y", "val_y", 1);
        Assert.Equal("val_x", tm.Get("x", 1));
        Assert.Equal("val_y", tm.Get("y", 1));
    }

    [Fact]
    public void LargeTimestampGap()
    {
        var tm = new TimeBasedKeyValueStore();
        tm.Set("k", "first", 1);
        tm.Set("k", "second", 1000);
        Assert.Equal("first", tm.Get("k", 500));
        Assert.Equal("second", tm.Get("k", 1000));
    }
}
