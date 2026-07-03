public class IntersectionOfTwoLinkedListsTests
{
    // Helper to build a linked list from array
    private ListNode BuildList(int[] values)
    {
        if (values.Length == 0) return null!;
        var head = new ListNode(values[0]);
        var current = head;
        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }
        return head;
    }

    // Helper to get node at index
    private ListNode GetNodeAt(ListNode head, int index)
    {
        var current = head;
        for (int i = 0; i < index; i++) current = current.next;
        return current;
    }

    // Helper to attach listA's tail to a node in shared
    private ListNode AttachAt(int[] prefix, ListNode intersection)
    {
        if (prefix.Length == 0) return intersection;
        var head = BuildList(prefix);
        var tail = GetNodeAt(head, prefix.Length - 1);
        tail.next = intersection;
        return head;
    }

    // Example 1: intersectVal=8, listA=[4,1,8,4,5], listB=[5,6,1,8,4,5]
    [Fact]
    public void Example1_IntersectionAt8()
    {
        var shared = BuildList([8, 4, 5]);
        var headA = AttachAt([4, 1], shared);
        var headB = AttachAt([5, 6, 1], shared);

        var result = new IntersectionOfTwoLinkedLists().GetIntersectionNode(headA, headB);
        Assert.Same(shared, result);
    }

    // Example 2: intersectVal=2, listA=[1,9,1,2,4], listB=[3,2,4]
    [Fact]
    public void Example2_IntersectionAt2()
    {
        var shared = BuildList([2, 4]);
        var headA = AttachAt([1, 9, 1], shared);
        var headB = AttachAt([3], shared);

        var result = new IntersectionOfTwoLinkedLists().GetIntersectionNode(headA, headB);
        Assert.Same(shared, result);
    }

    // Example 3: No intersection
    [Fact]
    public void Example3_NoIntersection()
    {
        var headA = BuildList([2, 6, 4]);
        var headB = BuildList([1, 5]);

        var result = new IntersectionOfTwoLinkedLists().GetIntersectionNode(headA, headB);
        Assert.Null(result);
    }

    [Fact]
    public void IntersectionAtHead_BothSameList()
    {
        var shared = BuildList([1, 2, 3]);

        var result = new IntersectionOfTwoLinkedLists().GetIntersectionNode(shared, shared);
        Assert.Same(shared, result);
    }

    [Fact]
    public void IntersectionAtLastNode()
    {
        var shared = new ListNode(99);
        var headA = AttachAt([1, 2, 3], shared);
        var headB = AttachAt([7, 8], shared);

        var result = new IntersectionOfTwoLinkedLists().GetIntersectionNode(headA, headB);
        Assert.Same(shared, result);
    }

    [Fact]
    public void OneListIsEmpty()
    {
        var headA = BuildList([1, 2, 3]);

        var result = new IntersectionOfTwoLinkedLists().GetIntersectionNode(headA, null!);
        Assert.Null(result);
    }

    [Fact]
    public void SameValuesDifferentNodes_NoIntersection()
    {
        var headA = BuildList([1, 2, 3]);
        var headB = BuildList([1, 2, 3]);

        var result = new IntersectionOfTwoLinkedLists().GetIntersectionNode(headA, headB);
        Assert.Null(result);
    }
}
