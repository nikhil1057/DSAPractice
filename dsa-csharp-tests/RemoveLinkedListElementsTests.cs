public class RemoveLinkedListElementsTests
{
    private ListNode? BuildList(int[] values)
    {
        if (values.Length == 0) return null;
        var head = new ListNode(values[0]);
        var current = head;
        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }
        return head;
    }

    private int[] ToArray(ListNode? head)
    {
        var result = new List<int>();
        while (head != null) { result.Add(head.val); head = head.next; }
        return result.ToArray();
    }

    [Fact]
    public void Example1()
    {
        var result = new RemoveLinkedListElements().RemoveElements(BuildList([1, 2, 6, 3, 4, 5, 6]), 6);
        Assert.Equal(new[] { 1, 2, 3, 4, 5 }, ToArray(result));
    }

    [Fact]
    public void Example2_Empty()
    {
        Assert.Null(new RemoveLinkedListElements().RemoveElements(null, 1));
    }

    [Fact]
    public void Example3_AllSame()
    {
        Assert.Null(new RemoveLinkedListElements().RemoveElements(BuildList([7, 7, 7, 7]), 7));
    }

    [Fact]
    public void RemoveHead()
    {
        var result = new RemoveLinkedListElements().RemoveElements(BuildList([1, 2, 3]), 1);
        Assert.Equal(new[] { 2, 3 }, ToArray(result));
    }

    [Fact]
    public void RemoveTail()
    {
        var result = new RemoveLinkedListElements().RemoveElements(BuildList([1, 2, 3]), 3);
        Assert.Equal(new[] { 1, 2 }, ToArray(result));
    }

    [Fact]
    public void NoMatch()
    {
        var result = new RemoveLinkedListElements().RemoveElements(BuildList([1, 2, 3]), 9);
        Assert.Equal(new[] { 1, 2, 3 }, ToArray(result));
    }

    [Fact]
    public void ConsecutiveAtHead()
    {
        var result = new RemoveLinkedListElements().RemoveElements(BuildList([1, 1, 2, 3]), 1);
        Assert.Equal(new[] { 2, 3 }, ToArray(result));
    }
}
