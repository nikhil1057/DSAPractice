public class ReverseLinkedListTests
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
        var result = new ReverseLinkedList().ReverseList(BuildList([1, 2, 3, 4, 5]));
        Assert.Equal(new[] { 5, 4, 3, 2, 1 }, ToArray(result));
    }

    [Fact]
    public void Example2()
    {
        var result = new ReverseLinkedList().ReverseList(BuildList([1, 2]));
        Assert.Equal(new[] { 2, 1 }, ToArray(result));
    }

    [Fact]
    public void Example3_Empty()
    {
        Assert.Null(new ReverseLinkedList().ReverseList(null));
    }

    [Fact]
    public void SingleNode()
    {
        var result = new ReverseLinkedList().ReverseList(BuildList([1]));
        Assert.Equal(new[] { 1 }, ToArray(result));
    }

    [Fact]
    public void ThreeElements()
    {
        var result = new ReverseLinkedList().ReverseList(BuildList([1, 2, 3]));
        Assert.Equal(new[] { 3, 2, 1 }, ToArray(result));
    }
}
