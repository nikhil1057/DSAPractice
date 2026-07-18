public class ConstructBinaryTreeFromPreorderAndInorderTraversalTests
{
    private List<int?> TreeToList(TreeNode? root)
    {
        var result = new List<int?>();
        if (root == null) return result;
        var queue = new Queue<TreeNode?>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (node != null)
            {
                result.Add(node.val);
                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            }
            else
            {
                result.Add(null);
            }
        }
        while (result.Count > 0 && result[^1] == null) result.RemoveAt(result.Count - 1);
        return result;
    }

    [Fact]
    public void Example1()
    {
        var result = new ConstructBinaryTreeFromPreorderAndInorderTraversal()
            .BuildTree([3, 9, 20, 15, 7], [9, 3, 15, 20, 7]);
        Assert.Equal(new int?[] { 3, 9, 20, null, null, 15, 7 }, TreeToList(result));
    }

    [Fact]
    public void Example2()
    {
        var result = new ConstructBinaryTreeFromPreorderAndInorderTraversal()
            .BuildTree([-1], [-1]);
        Assert.Equal(new int?[] { -1 }, TreeToList(result));
    }

    [Fact]
    public void LeftSkewed()
    {
        var result = new ConstructBinaryTreeFromPreorderAndInorderTraversal()
            .BuildTree([3, 2, 1], [1, 2, 3]);
        Assert.Equal(new int?[] { 3, 2, null, 1 }, TreeToList(result));
    }

    [Fact]
    public void RightSkewed()
    {
        var result = new ConstructBinaryTreeFromPreorderAndInorderTraversal()
            .BuildTree([1, 2, 3], [1, 2, 3]);
        Assert.Equal(new int?[] { 1, null, 2, null, 3 }, TreeToList(result));
    }

    [Fact]
    public void CompleteTree()
    {
        var result = new ConstructBinaryTreeFromPreorderAndInorderTraversal()
            .BuildTree([1, 2, 4, 5, 3, 6, 7], [4, 2, 5, 1, 6, 3, 7]);
        Assert.Equal(new int?[] { 1, 2, 3, 4, 5, 6, 7 }, TreeToList(result));
    }

    [Fact]
    public void TwoNodes()
    {
        var result = new ConstructBinaryTreeFromPreorderAndInorderTraversal()
            .BuildTree([1, 2], [2, 1]);
        Assert.Equal(new int?[] { 1, 2 }, TreeToList(result));
    }
}
