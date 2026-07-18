public class KthSmallestElementInABstTests
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
        var root = BuildTree([3, 1, 4, null, 2]);
        Assert.Equal(1, new KthSmallestElementInABst().KthSmallest(root, 1));
    }

    [Fact]
    public void Example2()
    {
        var root = BuildTree([5, 3, 6, 2, 4, null, null, 1]);
        Assert.Equal(3, new KthSmallestElementInABst().KthSmallest(root, 3));
    }

    [Fact]
    public void SingleNode()
    {
        var root = BuildTree([1]);
        Assert.Equal(1, new KthSmallestElementInABst().KthSmallest(root, 1));
    }

    [Fact]
    public void KEqualsN()
    {
        var root = BuildTree([3, 1, 4, null, 2]);
        Assert.Equal(4, new KthSmallestElementInABst().KthSmallest(root, 4));
    }

    [Fact]
    public void LeftSkewed()
    {
        var root = BuildTree([3, 2, null, 1]);
        Assert.Equal(2, new KthSmallestElementInABst().KthSmallest(root, 2));
    }

    [Fact]
    public void LargeK()
    {
        var root = BuildTree([5, 3, 7, 2, 4, 6, 8]);
        Assert.Equal(6, new KthSmallestElementInABst().KthSmallest(root, 5));
    }
}
