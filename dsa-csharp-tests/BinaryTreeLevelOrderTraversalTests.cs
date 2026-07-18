public class BinaryTreeLevelOrderTraversalTests
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
        var result = new BinaryTreeLevelOrderTraversal().LevelOrder(root);
        Assert.Equal(3, result.Count);
        Assert.Equal(new[] { 3 }, result[0]);
        Assert.Equal(new[] { 9, 20 }, result[1]);
        Assert.Equal(new[] { 15, 7 }, result[2]);
    }

    [Fact]
    public void Example2()
    {
        var root = BuildTree([1]);
        var result = new BinaryTreeLevelOrderTraversal().LevelOrder(root);
        Assert.Single(result);
        Assert.Equal(new[] { 1 }, result[0]);
    }

    [Fact]
    public void EmptyTree()
    {
        var result = new BinaryTreeLevelOrderTraversal().LevelOrder(null);
        Assert.Empty(result);
    }

    [Fact]
    public void TwoLevels()
    {
        var root = BuildTree([1, 2, 3]);
        var result = new BinaryTreeLevelOrderTraversal().LevelOrder(root);
        Assert.Equal(new[] { 1 }, result[0]);
        Assert.Equal(new[] { 2, 3 }, result[1]);
    }

    [Fact]
    public void LeftSkewed()
    {
        var root = BuildTree([1, 2, null, 3]);
        var result = new BinaryTreeLevelOrderTraversal().LevelOrder(root);
        Assert.Equal(new[] { 1 }, result[0]);
        Assert.Equal(new[] { 2 }, result[1]);
        Assert.Equal(new[] { 3 }, result[2]);
    }

    [Fact]
    public void CompleteTree()
    {
        var root = BuildTree([1, 2, 3, 4, 5, 6, 7]);
        var result = new BinaryTreeLevelOrderTraversal().LevelOrder(root);
        Assert.Equal(new[] { 1 }, result[0]);
        Assert.Equal(new[] { 2, 3 }, result[1]);
        Assert.Equal(new[] { 4, 5, 6, 7 }, result[2]);
    }
}
