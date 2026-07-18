public class CloneGraphTests
{
    private GraphNode BuildGraph(int[][] adjList)
    {
        if (adjList.Length == 0) return null!;
        var nodes = new GraphNode[adjList.Length];
        for (int i = 0; i < adjList.Length; i++)
            nodes[i] = new GraphNode(i + 1);
        for (int i = 0; i < adjList.Length; i++)
            foreach (var n in adjList[i])
                nodes[i].neighbors.Add(nodes[n - 1]);
        return nodes[0];
    }

    [Fact]
    public void Example1()
    {
        var node = BuildGraph([[2, 4], [1, 3], [2, 4], [1, 3]]);
        var clone = new CloneGraph().CloneGraphSolve(node);
        Assert.NotNull(clone);
        Assert.NotSame(node, clone);
        Assert.Equal(1, clone.val);
    }

    [Fact]
    public void SingleNodeNoNeighbors()
    {
        var node = new GraphNode(1);
        var clone = new CloneGraph().CloneGraphSolve(node);
        Assert.NotNull(clone);
        Assert.NotSame(node, clone);
        Assert.Equal(1, clone.val);
    }

    [Fact]
    public void NullInput()
    {
        var clone = new CloneGraph().CloneGraphSolve(null);
        Assert.Null(clone);
    }

    [Fact]
    public void DeepCopy()
    {
        var node = BuildGraph([[2], [1]]);
        var clone = new CloneGraph().CloneGraphSolve(node);
        Assert.NotSame(node, clone);
        Assert.NotSame(node.neighbors[0], clone!.neighbors[0]);
    }

    [Fact]
    public void ThreeNodeCycle()
    {
        var node = BuildGraph([[2, 3], [1, 3], [1, 2]]);
        var clone = new CloneGraph().CloneGraphSolve(node);
        Assert.NotNull(clone);
        Assert.Equal(2, clone.neighbors.Count);
    }
}
