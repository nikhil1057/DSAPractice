public class MergeKSortedListsTests
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
        var lists = new ListNode?[] { BuildList([1, 4, 5]), BuildList([1, 3, 4]), BuildList([2, 6]) };
        var result = new MergeKSortedLists().MergeKLists(lists);
        Assert.Equal(new[] { 1, 1, 2, 3, 4, 4, 5, 6 }, ToArray(result));
    }

    [Fact]
    public void Example2_EmptyArray()
    {
        Assert.Null(new MergeKSortedLists().MergeKLists([]));
    }

    [Fact]
    public void Example3_SingleEmptyList()
    {
        Assert.Null(new MergeKSortedLists().MergeKLists([null]));
    }

    [Fact]
    public void SingleList()
    {
        var lists = new ListNode?[] { BuildList([1, 2, 3]) };
        var result = new MergeKSortedLists().MergeKLists(lists);
        Assert.Equal(new[] { 1, 2, 3 }, ToArray(result));
    }

    [Fact]
    public void TwoLists()
    {
        var lists = new ListNode?[] { BuildList([1, 3, 5]), BuildList([2, 4, 6]) };
        var result = new MergeKSortedLists().MergeKLists(lists);
        Assert.Equal(new[] { 1, 2, 3, 4, 5, 6 }, ToArray(result));
    }

    [Fact]
    public void AllEmptyLists()
    {
        var lists = new ListNode?[] { null, null, null };
        Assert.Null(new MergeKSortedLists().MergeKLists(lists));
    }

    [Fact]
    public void SomeEmptyLists()
    {
        var lists = new ListNode?[] { null, BuildList([1, 3]), null, BuildList([2, 4]) };
        var result = new MergeKSortedLists().MergeKLists(lists);
        Assert.Equal(new[] { 1, 2, 3, 4 }, ToArray(result));
    }

    [Fact]
    public void SingleElementLists()
    {
        var lists = new ListNode?[] { BuildList([5]), BuildList([1]), BuildList([3]) };
        var result = new MergeKSortedLists().MergeKLists(lists);
        Assert.Equal(new[] { 1, 3, 5 }, ToArray(result));
    }

    [Fact]
    public void DuplicateValues()
    {
        var lists = new ListNode?[] { BuildList([1, 1, 1]), BuildList([1, 1]), BuildList([1]) };
        var result = new MergeKSortedLists().MergeKLists(lists);
        Assert.Equal(new[] { 1, 1, 1, 1, 1, 1 }, ToArray(result));
    }

    [Fact]
    public void NegativeValues()
    {
        var lists = new ListNode?[] { BuildList([-3, -1, 2]), BuildList([-2, 0, 4]) };
        var result = new MergeKSortedLists().MergeKLists(lists);
        Assert.Equal(new[] { -3, -2, -1, 0, 2, 4 }, ToArray(result));
    }
}
