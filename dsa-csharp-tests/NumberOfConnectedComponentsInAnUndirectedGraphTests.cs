public class NumberOfConnectedComponentsInAnUndirectedGraphTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(2, new NumberOfConnectedComponentsInAnUndirectedGraph().CountComponents(5, [[0, 1], [1, 2], [3, 4]]));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(1, new NumberOfConnectedComponentsInAnUndirectedGraph().CountComponents(5, [[0, 1], [1, 2], [2, 3], [3, 4]]));
    }

    [Fact]
    public void AllIsolated()
    {
        Assert.Equal(4, new NumberOfConnectedComponentsInAnUndirectedGraph().CountComponents(4, []));
    }

    [Fact]
    public void SingleNode()
    {
        Assert.Equal(1, new NumberOfConnectedComponentsInAnUndirectedGraph().CountComponents(1, []));
    }

    [Fact]
    public void FullyConnected()
    {
        Assert.Equal(1, new NumberOfConnectedComponentsInAnUndirectedGraph().CountComponents(3, [[0, 1], [1, 2], [0, 2]]));
    }

    [Fact]
    public void TwoComponents()
    {
        Assert.Equal(2, new NumberOfConnectedComponentsInAnUndirectedGraph().CountComponents(4, [[0, 1], [2, 3]]));
    }

    [Fact]
    public void ThreeComponents()
    {
        Assert.Equal(3, new NumberOfConnectedComponentsInAnUndirectedGraph().CountComponents(6, [[0, 1], [2, 3], [4, 5]]));
    }

    [Fact]
    public void StarGraph()
    {
        Assert.Equal(1, new NumberOfConnectedComponentsInAnUndirectedGraph().CountComponents(5, [[0, 1], [0, 2], [0, 3], [0, 4]]));
    }
}
