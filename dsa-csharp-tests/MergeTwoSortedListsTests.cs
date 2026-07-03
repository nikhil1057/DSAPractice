public class MergeTwoSortedListsTests
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
        var result = new MergeTwoSortedLists().MergeTwoLists(BuildList([1, 2, 4]), BuildList([1, 3, 4]));
        Assert.Equal(new[] { 1, 1, 2, 3, 4, 4 }, ToArray(result));
    }

    [Fact]
    public void Example2_BothEmpty()
    {
        Assert.Null(new MergeTwoSortedLists().MergeTwoLists(null, null));
    }

    [Fact]
    public void Example3_OneEmpty()
    {
        var result = new MergeTwoSortedLists().MergeTwoLists(null, BuildList([0]));
        Assert.Equal(new[] { 0 }, ToArray(result));
    }

    [Fact]
    public void FirstEmpty()
    {
        var result = new MergeTwoSortedLists().MergeTwoLists(null, BuildList([1, 2, 3]));
        Assert.Equal(new[] { 1, 2, 3 }, ToArray(result));
    }

    [Fact]
    public void SecondEmpty()
    {
        var result = new MergeTwoSortedLists().MergeTwoLists(BuildList([1, 2, 3]), null);
        Assert.Equal(new[] { 1, 2, 3 }, ToArray(result));
    }

    [Fact]
    public void DifferentLengths()
    {
        var result = new MergeTwoSortedLists().MergeTwoLists(BuildList([1, 5]), BuildList([2, 3, 4, 6]));
        Assert.Equal(new[] { 1, 2, 3, 4, 5, 6 }, ToArray(result));
    }

    [Fact]
    public void SingleElements()
    {
        var result = new MergeTwoSortedLists().MergeTwoLists(BuildList([2]), BuildList([1]));
        Assert.Equal(new[] { 1, 2 }, ToArray(result));
    }
}
