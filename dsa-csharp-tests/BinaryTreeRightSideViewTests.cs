public class BinaryTreeRightSideViewTests
{
    private TreeNode? BuildTree(int?[] values)
    {
        if (values.Length == 0 || values[0] == null) return null;
        var root = new TreeNode(values[0].Value);
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int i = 1;
        while (queue.Count > 0 && i < values.Length)
        {
            var node = queue.Dequeue();
            if (i < values.Length && values[i] != null)
            {
                node.left = new TreeNode(values[i].Value);
                queue.Enqueue(node.left);
            }
            i++;
            if (i < values.Length && values[i] != null)
            {
                node.right = new TreeNode(values[i].Value);
                queue.Enqueue(node.right);
            }
            i++;
        }
        return root;
    }

    [Fact]
    public void Example1()
    {
        var root = BuildTree([1, 2, 3, null, 5, null, 4]);
        Assert.Equal(new[] { 1, 3, 4 }, new BinaryTreeRightSideView().RightSideView(root));
    }

    [Fact]
    public void Example2()
    {
        var root = BuildTree([1, null, 3]);
        Assert.Equal(new[] { 1, 3 }, new BinaryTreeRightSideView().RightSideView(root));
    }

    [Fact]
    public void EmptyTree()
    {
        Assert.Empty(new BinaryTreeRightSideView().RightSideView(null));
    }

    [Fact]
    public void SingleNode()
    {
        var root = BuildTree([1]);
        Assert.Equal(new[] { 1 }, new BinaryTreeRightSideView().RightSideView(root));
    }

    [Fact]
    public void LeftOnly()
    {
        var root = BuildTree([1, 2, null, 3]);
        Assert.Equal(new[] { 1, 2, 3 }, new BinaryTreeRightSideView().RightSideView(root));
    }

    [Fact]
    public void CompleteTree()
    {
        var root = BuildTree([1, 2, 3, 4, 5, 6, 7]);
        Assert.Equal(new[] { 1, 3, 7 }, new BinaryTreeRightSideView().RightSideView(root));
    }

    [Fact]
    public void DeeperLeft()
    {
        var root = BuildTree([1, 2, 3, 4]);
        Assert.Equal(new[] { 1, 3, 4 }, new BinaryTreeRightSideView().RightSideView(root));
    }
}
