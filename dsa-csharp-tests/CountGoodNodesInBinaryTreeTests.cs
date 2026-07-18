public class CountGoodNodesInBinaryTreeTests
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
        var root = BuildTree([3, 1, 4, 3, null, 1, 5]);
        Assert.Equal(4, new CountGoodNodesInBinaryTree().GoodNodes(root!));
    }

    [Fact]
    public void Example2()
    {
        var root = BuildTree([3, 3, null, 4, 2]);
        Assert.Equal(3, new CountGoodNodesInBinaryTree().GoodNodes(root!));
    }

    [Fact]
    public void Example3()
    {
        var root = BuildTree([1]);
        Assert.Equal(1, new CountGoodNodesInBinaryTree().GoodNodes(root!));
    }

    [Fact]
    public void AllSameValue()
    {
        var root = BuildTree([3, 3, 3, 3, 3]);
        Assert.Equal(5, new CountGoodNodesInBinaryTree().GoodNodes(root!));
    }

    [Fact]
    public void IncreasingPath()
    {
        var root = BuildTree([1, null, 2, null, 3]);
        Assert.Equal(3, new CountGoodNodesInBinaryTree().GoodNodes(root!));
    }

    [Fact]
    public void DecreasingPath()
    {
        var root = BuildTree([3, null, 2, null, 1]);
        Assert.Equal(1, new CountGoodNodesInBinaryTree().GoodNodes(root!));
    }

    [Fact]
    public void NegativeValues()
    {
        var root = BuildTree([-1, -2, -3]);
        Assert.Equal(1, new CountGoodNodesInBinaryTree().GoodNodes(root!));
    }
}
