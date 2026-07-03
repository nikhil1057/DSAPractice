public class DesignLinkedListTests
{
    // LeetCode 707 - Example 1
    [Fact]
    public void LeetCode_Example1()
    {
        var list = new MyLinkedList();
        list.AddAtHead(1);
        list.AddAtTail(3);
        list.AddAtIndex(1, 2);    // list: 1->2->3
        Assert.Equal(2, list.Get(1));
        list.DeleteAtIndex(1);    // list: 1->3
        Assert.Equal(3, list.Get(1));
    }

    [Fact]
    public void Get_EmptyList_ReturnsNegativeOne()
    {
        var list = new MyLinkedList();
        Assert.Equal(-1, list.Get(0));
    }

    [Fact]
    public void Get_InvalidIndex_ReturnsNegativeOne()
    {
        var list = new MyLinkedList();
        list.AddAtHead(1);
        Assert.Equal(-1, list.Get(5));
    }

    [Fact]
    public void AddAtHead_MultipleTimes()
    {
        var list = new MyLinkedList();
        list.AddAtHead(3);
        list.AddAtHead(2);
        list.AddAtHead(1);
        Assert.Equal(1, list.Get(0));
        Assert.Equal(2, list.Get(1));
        Assert.Equal(3, list.Get(2));
    }

    [Fact]
    public void AddAtTail_MultipleTimes()
    {
        var list = new MyLinkedList();
        list.AddAtTail(1);
        list.AddAtTail(2);
        list.AddAtTail(3);
        Assert.Equal(1, list.Get(0));
        Assert.Equal(2, list.Get(1));
        Assert.Equal(3, list.Get(2));
    }

    [Fact]
    public void AddAtIndex_Beginning()
    {
        var list = new MyLinkedList();
        list.AddAtTail(1);
        list.AddAtTail(3);
        list.AddAtIndex(0, 0);    // list: 0->1->3
        Assert.Equal(0, list.Get(0));
        Assert.Equal(1, list.Get(1));
    }

    [Fact]
    public void AddAtIndex_End()
    {
        var list = new MyLinkedList();
        list.AddAtTail(1);
        list.AddAtTail(2);
        list.AddAtIndex(2, 3);    // list: 1->2->3
        Assert.Equal(3, list.Get(2));
    }

    [Fact]
    public void AddAtIndex_InvalidIndex_DoesNothing()
    {
        var list = new MyLinkedList();
        list.AddAtTail(1);
        list.AddAtIndex(5, 99);
        Assert.Equal(-1, list.Get(1));
    }

    [Fact]
    public void AddAtIndex_Middle()
    {
        // list: 1->2->4, insert 3 at index 2 => 1->2->3->4
        var list = new MyLinkedList();
        list.AddAtTail(1);
        list.AddAtTail(2);
        list.AddAtTail(4);
        list.AddAtIndex(2, 3);
        Assert.Equal(1, list.Get(0));
        Assert.Equal(2, list.Get(1));
        Assert.Equal(3, list.Get(2));
        Assert.Equal(4, list.Get(3));
    }

    [Fact]
    public void DeleteAtIndex_Middle()
    {
        // list: 1->2->3->4, delete index 2 => 1->2->4
        var list = new MyLinkedList();
        list.AddAtTail(1);
        list.AddAtTail(2);
        list.AddAtTail(3);
        list.AddAtTail(4);
        list.DeleteAtIndex(2);
        Assert.Equal(1, list.Get(0));
        Assert.Equal(2, list.Get(1));
        Assert.Equal(4, list.Get(2));
    }

    [Fact]
    public void DeleteAtIndex_Head()
    {
        var list = new MyLinkedList();
        list.AddAtTail(1);
        list.AddAtTail(2);
        list.DeleteAtIndex(0);
        Assert.Equal(2, list.Get(0));
    }

    [Fact]
    public void DeleteAtIndex_Tail()
    {
        var list = new MyLinkedList();
        list.AddAtTail(1);
        list.AddAtTail(2);
        list.AddAtTail(3);
        list.DeleteAtIndex(2);
        Assert.Equal(-1, list.Get(2));
        Assert.Equal(2, list.Get(1));
    }
}
