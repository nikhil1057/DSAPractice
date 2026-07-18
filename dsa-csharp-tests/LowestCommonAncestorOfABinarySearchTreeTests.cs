public class LowestCommonAncestorOfABinarySearchTreeTests
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

    private TreeNode? FindNode(TreeNode? root, int val)
    {
        if (root == null) return null;
        if (root.val == val) return root;
        return FindNode(root.left, val) ?? FindNode(root.right, val);
    }

    [Fact]
    public void Example1()
    {
        var root = BuildTree([6, 2, 8, 0, 4, 7, 9, null, null, 3, 5]);
        var p = FindNode(root, 2)!;
        var q = FindNode(root, 8)!;
        Assert.Equal(6, new LowestCommonAncestorOfABinarySearchTree().LowestCommonAncestor(root!, p, q).val);
    }

    [Fact]
    public void Example2()
    {
        var root = BuildTree([6, 2, 8, 0, 4, 7, 9, null, null, 3, 5]);
        var p = FindNode(root, 2)!;
        var q = FindNode(root, 4)!;
        Assert.Equal(2, new LowestCommonAncestorOfABinarySearchTree().LowestCommonAncestor(root!, p, q).val);
    }

    [Fact]
    public void Example3()
    {
        var root = BuildTree([2, 1]);
        var p = FindNode(root, 2)!;
        var q = FindNode(root, 1)!;
        Assert.Equal(2, new LowestCommonAncestorOfABinarySearchTree().LowestCommonAncestor(root!, p, q).val);
    }

    [Fact]
    public void BothInRight()
    {
        var root = BuildTree([6, 2, 8, 0, 4, 7, 9]);
        var p = FindNode(root, 7)!;
        var q = FindNode(root, 9)!;
        Assert.Equal(8, new LowestCommonAncestorOfABinarySearchTree().LowestCommonAncestor(root!, p, q).val);
    }

    [Fact]
    public void BothInLeft()
    {
        var root = BuildTree([6, 2, 8, 0, 4, 7, 9]);
        var p = FindNode(root, 0)!;
        var q = FindNode(root, 4)!;
        Assert.Equal(2, new LowestCommonAncestorOfABinarySearchTree().LowestCommonAncestor(root!, p, q).val);
    }

    [Fact]
    public void RootIsLCA()
    {
        var root = BuildTree([5, 3, 7, 1, 4, 6, 8]);
        var p = FindNode(root, 1)!;
        var q = FindNode(root, 8)!;
        Assert.Equal(5, new LowestCommonAncestorOfABinarySearchTree().LowestCommonAncestor(root!, p, q).val);
    }
}
