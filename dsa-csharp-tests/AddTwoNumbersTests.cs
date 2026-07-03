public class AddTwoNumbersTests
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
        // 342 + 465 = 807 => [2,4,3] + [5,6,4] => [7,0,8]
        var result = new AddTwoNumbers().AddTwoNumbersSolution(BuildList([2, 4, 3]), BuildList([5, 6, 4]));
        Assert.Equal(new[] { 7, 0, 8 }, ToArray(result));
    }

    [Fact]
    public void Example2_BothZero()
    {
        // 0 + 0 = 0
        var result = new AddTwoNumbers().AddTwoNumbersSolution(BuildList([0]), BuildList([0]));
        Assert.Equal(new[] { 0 }, ToArray(result));
    }

    [Fact]
    public void Example3_LargeNumbers()
    {
        // 9999999 + 9999 = 10009998
        var result = new AddTwoNumbers().AddTwoNumbersSolution(
            BuildList([9, 9, 9, 9, 9, 9, 9]), BuildList([9, 9, 9, 9]));
        Assert.Equal(new[] { 8, 9, 9, 9, 0, 0, 0, 1 }, ToArray(result));
    }

    [Fact]
    public void DifferentLengths_WithCarry()
    {
        // 99 + 1 = 100 => [9,9] + [1] => [0,0,1]
        var result = new AddTwoNumbers().AddTwoNumbersSolution(BuildList([9, 9]), BuildList([1]));
        Assert.Equal(new[] { 0, 0, 1 }, ToArray(result));
    }

    [Fact]
    public void NoCarry()
    {
        // 123 + 456 = 579 => [3,2,1] + [6,5,4] => [9,7,5]
        var result = new AddTwoNumbers().AddTwoNumbersSolution(BuildList([3, 2, 1]), BuildList([6, 5, 4]));
        Assert.Equal(new[] { 9, 7, 5 }, ToArray(result));
    }

    [Fact]
    public void SingleDigit_WithCarry()
    {
        // 5 + 5 = 10 => [5] + [5] => [0,1]
        var result = new AddTwoNumbers().AddTwoNumbersSolution(BuildList([5]), BuildList([5]));
        Assert.Equal(new[] { 0, 1 }, ToArray(result));
    }
}
