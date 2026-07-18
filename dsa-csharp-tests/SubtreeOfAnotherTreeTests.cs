public class SubtreeOfAnotherTreeTests
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
        var root = BuildTree([3, 4, 5, 1, 2]);
        var subRoot = BuildTree([4, 1, 2]);
        Assert.True(new SubtreeOfAnotherTree().IsSubtree(root, subRoot));
    }

    [Fact]
    public void Example2()
    {
        var root = BuildTree([3, 4, 5, 1, 2, null, null, null, null, 0]);
        var subRoot = BuildTree([4, 1, 2]);
        Assert.False(new SubtreeOfAnotherTree().IsSubtree(root, subRoot));
    }

    [Fact]
    public void SameTree()
    {
        var root = BuildTree([1, 2, 3]);
        var subRoot = BuildTree([1, 2, 3]);
        Assert.True(new SubtreeOfAnotherTree().IsSubtree(root, subRoot));
    }

    [Fact]
    public void SingleNodeMatch()
    {
        var root = BuildTree([1, 2, 3]);
        var subRoot = BuildTree([2]);
        Assert.True(new SubtreeOfAnotherTree().IsSubtree(root, subRoot));
    }

    [Fact]
    public void SingleNodeNoMatch()
    {
        var root = BuildTree([1, 2, 3]);
        var subRoot = BuildTree([4]);
        Assert.False(new SubtreeOfAnotherTree().IsSubtree(root, subRoot));
    }

    [Fact]
    public void NullRoot()
    {
        var subRoot = BuildTree([1]);
        Assert.False(new SubtreeOfAnotherTree().IsSubtree(null, subRoot));
    }

    [Fact]
    public void LeafSubtree()
    {
        var root = BuildTree([1, 2, 3, 4, 5]);
        var subRoot = BuildTree([2, 4, 5]);
        Assert.True(new SubtreeOfAnotherTree().IsSubtree(root, subRoot));
    }
}
