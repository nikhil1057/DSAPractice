public class CopyListWithRandomPointerTests
{
    private static CopyListWithRandomPointer.Node? BuildList(int[] values, int?[] randomIndices)
    {
        if (values.Length == 0) return null;
        var nodes = new CopyListWithRandomPointer.Node[values.Length];
        for (int i = 0; i < values.Length; i++)
            nodes[i] = new CopyListWithRandomPointer.Node(values[i]);
        for (int i = 0; i < values.Length - 1; i++)
            nodes[i].next = nodes[i + 1];
        for (int i = 0; i < randomIndices.Length; i++)
            nodes[i].random = randomIndices[i].HasValue ? nodes[randomIndices[i]!.Value] : null;
        return nodes[0];
    }

    private static (int[] values, int?[] randoms) ToArrays(CopyListWithRandomPointer.Node? head)
    {
        var nodes = new List<CopyListWithRandomPointer.Node>();
        var curr = head;
        while (curr != null) { nodes.Add(curr); curr = curr.next; }
        var values = nodes.Select(n => n.val).ToArray();
        var randoms = nodes.Select(n => n.random == null ? (int?)null : nodes.IndexOf(n.random)).ToArray();
        return (values, randoms);
    }

    [Fact]
    public void Example1()
    {
        var head = BuildList(new[] { 7, 13, 11, 10, 1 }, new int?[] { null, 0, 4, 2, 0 });
        var copy = new CopyListWithRandomPointer().CopyRandomList(head);
        var (values, randoms) = ToArrays(copy);
        Assert.Equal(new[] { 7, 13, 11, 10, 1 }, values);
        Assert.Equal(new int?[] { null, 0, 4, 2, 0 }, randoms);
    }

    [Fact]
    public void Example2()
    {
        var head = BuildList(new[] { 1, 2 }, new int?[] { 1, 1 });
        var copy = new CopyListWithRandomPointer().CopyRandomList(head);
        var (values, randoms) = ToArrays(copy);
        Assert.Equal(new[] { 1, 2 }, values);
        Assert.Equal(new int?[] { 1, 1 }, randoms);
    }

    [Fact]
    public void Example3()
    {
        var head = BuildList(new[] { 3, 3, 3 }, new int?[] { null, 0, null });
        var copy = new CopyListWithRandomPointer().CopyRandomList(head);
        var (values, randoms) = ToArrays(copy);
        Assert.Equal(new[] { 3, 3, 3 }, values);
        Assert.Equal(new int?[] { null, 0, null }, randoms);
    }

    [Fact]
    public void EmptyList()
    {
        Assert.Null(new CopyListWithRandomPointer().CopyRandomList(null));
    }

    [Fact]
    public void SingleNodeSelfRandom()
    {
        var node = new CopyListWithRandomPointer.Node(1);
        node.random = node;
        var copy = new CopyListWithRandomPointer().CopyRandomList(node);
        Assert.Equal(1, copy!.val);
        Assert.Same(copy, copy.random);
        Assert.NotSame(node, copy);
    }

    [Fact]
    public void DeepCopyIsIndependent()
    {
        var head = BuildList(new[] { 1, 2 }, new int?[] { null, 0 });
        var copy = new CopyListWithRandomPointer().CopyRandomList(head);
        Assert.NotSame(head, copy);
        Assert.NotSame(head!.next, copy!.next);
    }
}
