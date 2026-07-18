public class GraphValidTreeTests
{
    [Fact]
    public void Example1()
    {
        Assert.True(new GraphValidTree().ValidTree(5, [[0, 1], [0, 2], [0, 3], [1, 4]]));
    }

    [Fact]
    public void Example2_WithCycle()
    {
        Assert.False(new GraphValidTree().ValidTree(5, [[0, 1], [1, 2], [2, 3], [1, 3], [1, 4]]));
    }

    [Fact]
    public void SingleNode()
    {
        Assert.True(new GraphValidTree().ValidTree(1, []));
    }

    [Fact]
    public void TwoNodesConnected()
    {
        Assert.True(new GraphValidTree().ValidTree(2, [[0, 1]]));
    }

    [Fact]
    public void TwoNodesDisconnected()
    {
        Assert.False(new GraphValidTree().ValidTree(2, []));
    }

    [Fact]
    public void DisconnectedGraph()
    {
        Assert.False(new GraphValidTree().ValidTree(4, [[0, 1], [2, 3]]));
    }

    [Fact]
    public void LinearTree()
    {
        Assert.True(new GraphValidTree().ValidTree(4, [[0, 1], [1, 2], [2, 3]]));
    }

    [Fact]
    public void CycleThreeNodes()
    {
        Assert.False(new GraphValidTree().ValidTree(3, [[0, 1], [1, 2], [2, 0]]));
    }
}
