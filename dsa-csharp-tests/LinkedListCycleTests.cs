public class LinkedListCycleTests
{
    private ListNode? BuildCycleList(int[] values, int pos)
    {
        if (values.Length == 0) return null;
        var head = new ListNode(values[0]);
        var current = head;
        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }
        if (pos >= 0)
        {
            var tail = current;
            var cycleNode = head;
            for (int i = 0; i < pos; i++) cycleNode = cycleNode.next!;
            tail.next = cycleNode;
        }
        return head;
    }

    [Fact]
    public void Example1_CycleAtPos1()
    {
        Assert.True(new LinkedListCycle().HasCycle(BuildCycleList([3, 2, 0, -4], 1)));
    }

    [Fact]
    public void Example2_CycleAtPos0()
    {
        Assert.True(new LinkedListCycle().HasCycle(BuildCycleList([1, 2], 0)));
    }

    [Fact]
    public void Example3_NoCycle()
    {
        Assert.False(new LinkedListCycle().HasCycle(BuildCycleList([1], -1)));
    }

    [Fact]
    public void EmptyList()
    {
        Assert.False(new LinkedListCycle().HasCycle(null));
    }

    [Fact]
    public void NoCycle_MultipleNodes()
    {
        Assert.False(new LinkedListCycle().HasCycle(BuildCycleList([1, 2, 3, 4, 5], -1)));
    }

    [Fact]
    public void SingleNodeCycle()
    {
        var node = new ListNode(1);
        node.next = node;
        Assert.True(new LinkedListCycle().HasCycle(node));
    }

    [Fact]
    public void CycleAtTail()
    {
        Assert.True(new LinkedListCycle().HasCycle(BuildCycleList([1, 2, 3, 4], 3)));
    }
}
