public class ReverseNodesInKGroupTests
{
    private static ReverseNodesInKGroup.ListNode? BuildList(int[] values)
    {
        if (values.Length == 0) return null;
        var head = new ReverseNodesInKGroup.ListNode(values[0]);
        var current = head;
        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ReverseNodesInKGroup.ListNode(values[i]);
            current = current.next;
        }
        return head;
    }

    private static int[] ToArray(ReverseNodesInKGroup.ListNode? head)
    {
        var result = new List<int>();
        while (head != null)
        {
            result.Add(head.val);
            head = head.next;
        }
        return result.ToArray();
    }

    [Fact]
    public void Example1()
    {
        var head = BuildList(new[] { 1, 2, 3, 4, 5 });
        var result = new ReverseNodesInKGroup().ReverseKGroup(head, 2);
        Assert.Equal(new[] { 2, 1, 4, 3, 5 }, ToArray(result));
    }

    [Fact]
    public void Example2()
    {
        var head = BuildList(new[] { 1, 2, 3, 4, 5 });
        var result = new ReverseNodesInKGroup().ReverseKGroup(head, 3);
        Assert.Equal(new[] { 3, 2, 1, 4, 5 }, ToArray(result));
    }

    [Fact]
    public void KEqualsOne()
    {
        var head = BuildList(new[] { 1, 2, 3 });
        var result = new ReverseNodesInKGroup().ReverseKGroup(head, 1);
        Assert.Equal(new[] { 1, 2, 3 }, ToArray(result));
    }

    [Fact]
    public void KEqualsLength()
    {
        var head = BuildList(new[] { 1, 2, 3 });
        var result = new ReverseNodesInKGroup().ReverseKGroup(head, 3);
        Assert.Equal(new[] { 3, 2, 1 }, ToArray(result));
    }

    [Fact]
    public void KGreaterThanLength()
    {
        var head = BuildList(new[] { 1, 2 });
        var result = new ReverseNodesInKGroup().ReverseKGroup(head, 3);
        Assert.Equal(new[] { 1, 2 }, ToArray(result));
    }

    [Fact]
    public void SingleNode()
    {
        var head = BuildList(new[] { 1 });
        var result = new ReverseNodesInKGroup().ReverseKGroup(head, 1);
        Assert.Equal(new[] { 1 }, ToArray(result));
    }

    [Fact]
    public void EvenGroups()
    {
        var head = BuildList(new[] { 1, 2, 3, 4, 5, 6 });
        var result = new ReverseNodesInKGroup().ReverseKGroup(head, 2);
        Assert.Equal(new[] { 2, 1, 4, 3, 6, 5 }, ToArray(result));
    }

    [Fact]
    public void FullReversal()
    {
        var head = BuildList(new[] { 1, 2, 3, 4 });
        var result = new ReverseNodesInKGroup().ReverseKGroup(head, 4);
        Assert.Equal(new[] { 4, 3, 2, 1 }, ToArray(result));
    }
}
