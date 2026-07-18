public class InvertBinaryTreeTests
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

    private List<int?> TreeToList(TreeNode? root)
    {
        var result = new List<int?>();
        if (root == null) return result;
        var queue = new Queue<TreeNode?>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (node != null)
            {
                result.Add(node.val);
                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            }
            else
            {
                result.Add(null);
            }
        }
        while (result.Count > 0 && result[^1] == null) result.RemoveAt(result.Count - 1);
        return result;
    }

    [Fact]
    public void Example1()
    {
        var root = BuildTree([4, 2, 7, 1, 3, 6, 9]);
        var result = new InvertBinaryTree().InvertTree(root);
        Assert.Equal(new int?[] { 4, 7, 2, 9, 6, 3, 1 }, TreeToList(result));
    }

    [Fact]
    public void Example2()
    {
        var root = BuildTree([2, 1, 3]);
        var result = new InvertBinaryTree().InvertTree(root);
        Assert.Equal(new int?[] { 2, 3, 1 }, TreeToList(result));
    }

    [Fact]
    public void EmptyTree()
    {
        Assert.Null(new InvertBinaryTree().InvertTree(null));
    }

    [Fact]
    public void SingleNode()
    {
        var root = BuildTree([1]);
        var result = new InvertBinaryTree().InvertTree(root);
        Assert.Equal(new int?[] { 1 }, TreeToList(result));
    }

    [Fact]
    public void LeftSkewed()
    {
        var root = BuildTree([1, 2, null, 3]);
        var result = new InvertBinaryTree().InvertTree(root);
        Assert.Equal(new int?[] { 1, null, 2, null, 3 }, TreeToList(result));
    }

    [Fact]
    public void RightSkewed()
    {
        var root = BuildTree([1, null, 2, null, 3]);
        var result = new InvertBinaryTree().InvertTree(root);
        Assert.Equal(new int?[] { 1, 2, null, 3 }, TreeToList(result));
    }
}
