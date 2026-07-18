public class BinaryTreeMaximumPathSumTests
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
        var root = BuildTree([1, 2, 3]);
        Assert.Equal(6, new BinaryTreeMaximumPathSum().MaxPathSum(root));
    }

    [Fact]
    public void Example2()
    {
        var root = BuildTree([-10, 9, 20, null, null, 15, 7]);
        Assert.Equal(42, new BinaryTreeMaximumPathSum().MaxPathSum(root));
    }

    [Fact]
    public void SingleNode()
    {
        var root = BuildTree([1]);
        Assert.Equal(1, new BinaryTreeMaximumPathSum().MaxPathSum(root));
    }

    [Fact]
    public void SingleNegative()
    {
        var root = BuildTree([-3]);
        Assert.Equal(-3, new BinaryTreeMaximumPathSum().MaxPathSum(root));
    }

    [Fact]
    public void AllNegative()
    {
        var root = BuildTree([-1, -2, -3]);
        Assert.Equal(-1, new BinaryTreeMaximumPathSum().MaxPathSum(root));
    }

    [Fact]
    public void LeftPathOnly()
    {
        var root = BuildTree([1, 2, -1]);
        Assert.Equal(3, new BinaryTreeMaximumPathSum().MaxPathSum(root));
    }

    [Fact]
    public void Complex()
    {
        var root = BuildTree([5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1]);
        Assert.Equal(48, new BinaryTreeMaximumPathSum().MaxPathSum(root));
    }
}
