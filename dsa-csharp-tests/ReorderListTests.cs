public class ReorderListTests
{
    private static ReorderList.ListNode? BuildList(int[] values)
    {
        if (values.Length == 0) return null;
        var head = new ReorderList.ListNode(values[0]);
        var current = head;
        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ReorderList.ListNode(values[i]);
            current = current.next;
        }
        return head;
    }

    private static int[] ToArray(ReorderList.ListNode? head)
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
        var head = BuildList(new[] { 1, 2, 3, 4 });
        new ReorderList().ReorderListMethod(head);
        Assert.Equal(new[] { 1, 4, 2, 3 }, ToArray(head));
    }

    [Fact]
    public void Example2()
    {
        var head = BuildList(new[] { 1, 2, 3, 4, 5 });
        new ReorderList().ReorderListMethod(head);
        Assert.Equal(new[] { 1, 5, 2, 4, 3 }, ToArray(head));
    }

    [Fact]
    public void SingleNode()
    {
        var head = BuildList(new[] { 1 });
        new ReorderList().ReorderListMethod(head);
        Assert.Equal(new[] { 1 }, ToArray(head));
    }

    [Fact]
    public void TwoNodes()
    {
        var head = BuildList(new[] { 1, 2 });
        new ReorderList().ReorderListMethod(head);
        Assert.Equal(new[] { 1, 2 }, ToArray(head));
    }

    [Fact]
    public void ThreeNodes()
    {
        var head = BuildList(new[] { 1, 2, 3 });
        new ReorderList().ReorderListMethod(head);
        Assert.Equal(new[] { 1, 3, 2 }, ToArray(head));
    }

    [Fact]
    public void SixNodes()
    {
        var head = BuildList(new[] { 1, 2, 3, 4, 5, 6 });
        new ReorderList().ReorderListMethod(head);
        Assert.Equal(new[] { 1, 6, 2, 5, 3, 4 }, ToArray(head));
    }
}
