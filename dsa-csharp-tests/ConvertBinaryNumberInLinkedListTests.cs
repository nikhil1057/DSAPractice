public class ConvertBinaryNumberInLinkedListTests
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

    [Fact]
    public void Example1()
    {
        // 1->0->1 = 5
        Assert.Equal(5, new ConvertBinaryNumberInLinkedList().GetDecimalValue(BuildList([1, 0, 1])));
    }

    [Fact]
    public void Example2()
    {
        // 0 = 0
        Assert.Equal(0, new ConvertBinaryNumberInLinkedList().GetDecimalValue(BuildList([0])));
    }

    [Fact]
    public void Example3()
    {
        // 1 = 1
        Assert.Equal(1, new ConvertBinaryNumberInLinkedList().GetDecimalValue(BuildList([1])));
    }

    [Fact]
    public void AllOnes()
    {
        // 1->1->1->1 = 15
        Assert.Equal(15, new ConvertBinaryNumberInLinkedList().GetDecimalValue(BuildList([1, 1, 1, 1])));
    }

    [Fact]
    public void LeadingZeros()
    {
        // 0->0->1 = 1
        Assert.Equal(1, new ConvertBinaryNumberInLinkedList().GetDecimalValue(BuildList([0, 0, 1])));
    }

    [Fact]
    public void LargerNumber()
    {
        // 1->0->0->1->0 = 18
        Assert.Equal(18, new ConvertBinaryNumberInLinkedList().GetDecimalValue(BuildList([1, 0, 0, 1, 0])));
    }
}
