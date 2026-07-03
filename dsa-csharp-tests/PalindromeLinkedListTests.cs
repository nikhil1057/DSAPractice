public class PalindromeLinkedListTests
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
    public void Example1_Palindrome()
    {
        Assert.True(new PalindromeLinkedList().IsPalindrome(BuildList([1, 2, 2, 1])));
    }

    [Fact]
    public void Example2_NotPalindrome()
    {
        Assert.False(new PalindromeLinkedList().IsPalindrome(BuildList([1, 2])));
    }

    [Fact]
    public void SingleNode()
    {
        Assert.True(new PalindromeLinkedList().IsPalindrome(BuildList([1])));
    }

    [Fact]
    public void OddPalindrome()
    {
        Assert.True(new PalindromeLinkedList().IsPalindrome(BuildList([1, 2, 1])));
    }

    [Fact]
    public void OddNotPalindrome()
    {
        Assert.False(new PalindromeLinkedList().IsPalindrome(BuildList([1, 2, 3])));
    }

    [Fact]
    public void AllSame()
    {
        Assert.True(new PalindromeLinkedList().IsPalindrome(BuildList([1, 1, 1, 1])));
    }

    [Fact]
    public void LongerPalindrome()
    {
        Assert.True(new PalindromeLinkedList().IsPalindrome(BuildList([1, 2, 3, 2, 1])));
    }
}
