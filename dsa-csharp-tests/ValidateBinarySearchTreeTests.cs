public class ValidateBinarySearchTreeTests
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
        var root = BuildTree([2, 1, 3]);
        Assert.True(new ValidateBinarySearchTree().IsValidBST(root));
    }

    [Fact]
    public void Example2()
    {
        var root = BuildTree([5, 1, 4, null, null, 3, 6]);
        Assert.False(new ValidateBinarySearchTree().IsValidBST(root));
    }

    [Fact]
    public void SingleNode()
    {
        var root = BuildTree([1]);
        Assert.True(new ValidateBinarySearchTree().IsValidBST(root));
    }

    [Fact]
    public void EqualValues()
    {
        var root = BuildTree([2, 2, 2]);
        Assert.False(new ValidateBinarySearchTree().IsValidBST(root));
    }

    [Fact]
    public void ValidLarger()
    {
        var root = BuildTree([5, 3, 7, 2, 4, 6, 8]);
        Assert.True(new ValidateBinarySearchTree().IsValidBST(root));
    }

    [Fact]
    public void InvalidGrandchild()
    {
        var root = BuildTree([5, 1, 6, null, null, 3, 7]);
        Assert.False(new ValidateBinarySearchTree().IsValidBST(root));
    }

    [Fact]
    public void LeftSkewedValid()
    {
        var root = BuildTree([3, 2, null, 1]);
        Assert.True(new ValidateBinarySearchTree().IsValidBST(root));
    }
}
