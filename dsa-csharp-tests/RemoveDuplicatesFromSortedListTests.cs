public class RemoveDuplicatesFromSortedListTests
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

    // ===== 83. Remove Duplicates from Sorted List =====

    [Fact]
    public void Q83_Example1()
    {
        // [1,1,2] => [1,2]
        var result = new RemoveDuplicatesFromSortedList().DeleteDuplicates(BuildList([1, 1, 2]));
        Assert.Equal([1, 2], ToArray(result));
    }

    [Fact]
    public void Q83_Example2()
    {
        // [1,1,2,3,3] => [1,2,3]
        var result = new RemoveDuplicatesFromSortedList().DeleteDuplicates(BuildList([1, 1, 2, 3, 3]));
        Assert.Equal([1, 2, 3], ToArray(result));
    }

    [Fact]
    public void Q83_EmptyList()
    {
        var result = new RemoveDuplicatesFromSortedList().DeleteDuplicates(null);
        Assert.Null(result);
    }

    [Fact]
    public void Q83_SingleElement()
    {
        var result = new RemoveDuplicatesFromSortedList().DeleteDuplicates(BuildList([1]));
        Assert.Equal([1], ToArray(result));
    }

    [Fact]
    public void Q83_AllSame()
    {
        var result = new RemoveDuplicatesFromSortedList().DeleteDuplicates(BuildList([5, 5, 5, 5]));
        Assert.Equal([5], ToArray(result));
    }

    [Fact]
    public void Q83_NoDuplicates()
    {
        var result = new RemoveDuplicatesFromSortedList().DeleteDuplicates(BuildList([1, 2, 3]));
        Assert.Equal([1, 2, 3], ToArray(result));
    }

    // ===== 82. Remove Duplicates from Sorted List II =====

    [Fact]
    public void Q82_Example1()
    {
        // [1,2,3,3,4,4,5] => [1,2,5]
        var result = new RemoveDuplicatesFromSortedListII().DeleteDuplicates(BuildList([1, 2, 3, 3, 4, 4, 5]));
        Assert.Equal([1, 2, 5], ToArray(result));
    }

    [Fact]
    public void Q82_Example2()
    {
        // [1,1,1,2,3] => [2,3]
        var result = new RemoveDuplicatesFromSortedListII().DeleteDuplicates(BuildList([1, 1, 1, 2, 3]));
        Assert.Equal([2, 3], ToArray(result));
    }

    [Fact]
    public void Q82_EmptyList()
    {
        var result = new RemoveDuplicatesFromSortedListII().DeleteDuplicates(null);
        Assert.Null(result);
    }

    [Fact]
    public void Q82_SingleElement()
    {
        var result = new RemoveDuplicatesFromSortedListII().DeleteDuplicates(BuildList([1]));
        Assert.Equal([1], ToArray(result));
    }

    [Fact]
    public void Q82_AllDuplicates()
    {
        // [1,1,2,2,3,3] => []
        var result = new RemoveDuplicatesFromSortedListII().DeleteDuplicates(BuildList([1, 1, 2, 2, 3, 3]));
        Assert.Null(result);
    }

    [Fact]
    public void Q82_NoDuplicates()
    {
        var result = new RemoveDuplicatesFromSortedListII().DeleteDuplicates(BuildList([1, 2, 3]));
        Assert.Equal([1, 2, 3], ToArray(result));
    }

    [Fact]
    public void Q82_DuplicatesAtEnd()
    {
        // [1,2,3,3] => [1,2]
        var result = new RemoveDuplicatesFromSortedListII().DeleteDuplicates(BuildList([1, 2, 3, 3]));
        Assert.Equal([1, 2], ToArray(result));
    }

    [Fact]
    public void Q82_DuplicatesAtStart()
    {
        // [1,1,2,3] => [2,3]
        var result = new RemoveDuplicatesFromSortedListII().DeleteDuplicates(BuildList([1, 1, 2, 3]));
        Assert.Equal([2, 3], ToArray(result));
    }
}
