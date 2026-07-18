public class RemoveNthNodeFromEndOfListTests
{
    private static RemoveNthNodeFromEndOfList.ListNode? BuildList(int[] values)
    {
        if (values.Length == 0) return null;
        var head = new RemoveNthNodeFromEndOfList.ListNode(values[0]);
        var current = head;
        for (int i = 1; i < values.Length; i++)
        {
            current.next = new RemoveNthNodeFromEndOfList.ListNode(values[i]);
            current = current.next;
        }
        return head;
    }

    private static int[] ToArray(RemoveNthNodeFromEndOfList.ListNode? head)
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
        var result = new RemoveNthNodeFromEndOfList().RemoveNthFromEnd(head, 2);
        Assert.Equal(new[] { 1, 2, 3, 5 }, ToArray(result));
    }

    [Fact]
    public void Example2()
    {
        var head = BuildList(new[] { 1 });
        var result = new RemoveNthNodeFromEndOfList().RemoveNthFromEnd(head, 1);
        Assert.Equal(Array.Empty<int>(), ToArray(result));
    }

    [Fact]
    public void Example3()
    {
        var head = BuildList(new[] { 1, 2 });
        var result = new RemoveNthNodeFromEndOfList().RemoveNthFromEnd(head, 1);
        Assert.Equal(new[] { 1 }, ToArray(result));
    }

    [Fact]
    public void RemoveHead()
    {
        var head = BuildList(new[] { 1, 2 });
        var result = new RemoveNthNodeFromEndOfList().RemoveNthFromEnd(head, 2);
        Assert.Equal(new[] { 2 }, ToArray(result));
    }

    [Fact]
    public void RemoveMiddle()
    {
        var head = BuildList(new[] { 1, 2, 3 });
        var result = new RemoveNthNodeFromEndOfList().RemoveNthFromEnd(head, 2);
        Assert.Equal(new[] { 1, 3 }, ToArray(result));
    }

    [Fact]
    public void RemoveLast()
    {
        var head = BuildList(new[] { 1, 2, 3, 4 });
        var result = new RemoveNthNodeFromEndOfList().RemoveNthFromEnd(head, 1);
        Assert.Equal(new[] { 1, 2, 3 }, ToArray(result));
    }

    [Fact]
    public void LongList()
    {
        var head = BuildList(new[] { 1, 2, 3, 4, 5, 6, 7 });
        var result = new RemoveNthNodeFromEndOfList().RemoveNthFromEnd(head, 4);
        Assert.Equal(new[] { 1, 2, 3, 5, 6, 7 }, ToArray(result));
    }
}
