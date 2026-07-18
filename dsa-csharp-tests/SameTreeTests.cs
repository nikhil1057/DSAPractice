public class SameTreeTests
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
        var p = BuildTree([1, 2, 3]);
        var q = BuildTree([1, 2, 3]);
        Assert.True(new SameTree().IsSameTree(p, q));
    }

    [Fact]
    public void Example2()
    {
        var p = BuildTree([1, 2]);
        var q = BuildTree([1, null, 2]);
        Assert.False(new SameTree().IsSameTree(p, q));
    }

    [Fact]
    public void Example3()
    {
        var p = BuildTree([1, 2, 1]);
        var q = BuildTree([1, 1, 2]);
        Assert.False(new SameTree().IsSameTree(p, q));
    }

    [Fact]
    public void BothEmpty()
    {
        Assert.True(new SameTree().IsSameTree(null, null));
    }

    [Fact]
    public void OneEmpty()
    {
        var p = BuildTree([1]);
        Assert.False(new SameTree().IsSameTree(p, null));
    }

    [Fact]
    public void SingleSame()
    {
        var p = BuildTree([1]);
        var q = BuildTree([1]);
        Assert.True(new SameTree().IsSameTree(p, q));
    }

    [Fact]
    public void DifferentValues()
    {
        var p = BuildTree([1, 2, 3]);
        var q = BuildTree([1, 2, 4]);
        Assert.False(new SameTree().IsSameTree(p, q));
    }
}
