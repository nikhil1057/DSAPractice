public class MaximumDepthOfBinaryTreeTests
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
        var root = BuildTree([3, 9, 20, null, null, 15, 7]);
        Assert.Equal(3, new MaximumDepthOfBinaryTree().MaxDepth(root));
    }

    [Fact]
    public void Example2()
    {
        var root = BuildTree([1, null, 2]);
        Assert.Equal(2, new MaximumDepthOfBinaryTree().MaxDepth(root));
    }

    [Fact]
    public void EmptyTree()
    {
        Assert.Equal(0, new MaximumDepthOfBinaryTree().MaxDepth(null));
    }

    [Fact]
    public void SingleNode()
    {
        var root = BuildTree([1]);
        Assert.Equal(1, new MaximumDepthOfBinaryTree().MaxDepth(root));
    }

    [Fact]
    public void Balanced()
    {
        var root = BuildTree([1, 2, 3, 4, 5, 6, 7]);
        Assert.Equal(3, new MaximumDepthOfBinaryTree().MaxDepth(root));
    }

    [Fact]
    public void LeftSkewed()
    {
        var root = BuildTree([1, 2, null, 3, null, 4]);
        Assert.Equal(4, new MaximumDepthOfBinaryTree().MaxDepth(root));
    }
}
