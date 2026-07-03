public class MiddleOfTheLinkedListTests
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
    public void Example1_OddLength()
    {
        // [1,2,3,4,5] => middle is 3, return [3,4,5]
        var result = new MiddleOfTheLinkedList().MiddleNode(BuildList([1, 2, 3, 4, 5]));
        Assert.Equal(new[] { 3, 4, 5 }, ToArray(result));
    }

    [Fact]
    public void Example2_EvenLength()
    {
        // [1,2,3,4,5,6] => second middle is 4, return [4,5,6]
        var result = new MiddleOfTheLinkedList().MiddleNode(BuildList([1, 2, 3, 4, 5, 6]));
        Assert.Equal(new[] { 4, 5, 6 }, ToArray(result));
    }

    [Fact]
    public void SingleNode()
    {
        var result = new MiddleOfTheLinkedList().MiddleNode(BuildList([1]));
        Assert.Equal(new[] { 1 }, ToArray(result));
    }

    [Fact]
    public void TwoNodes()
    {
        // [1,2] => second middle is 2
        var result = new MiddleOfTheLinkedList().MiddleNode(BuildList([1, 2]));
        Assert.Equal(new[] { 2 }, ToArray(result));
    }

    [Fact]
    public void ThreeNodes()
    {
        var result = new MiddleOfTheLinkedList().MiddleNode(BuildList([1, 2, 3]));
        Assert.Equal(new[] { 2, 3 }, ToArray(result));
    }
}
