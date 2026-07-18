public class SerializeAndDeserializeBinaryTreeTests
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
        var codec = new Codec();
        var root = BuildTree([1, 2, 3, null, null, 4, 5]);
        var data = codec.Serialize(root);
        var result = codec.Deserialize(data);
        Assert.Equal(new int?[] { 1, 2, 3, null, null, 4, 5 }, TreeToList(result));
    }

    [Fact]
    public void EmptyTree()
    {
        var codec = new Codec();
        var data = codec.Serialize(null);
        Assert.Null(codec.Deserialize(data));
    }

    [Fact]
    public void SingleNode()
    {
        var codec = new Codec();
        var root = BuildTree([1]);
        var data = codec.Serialize(root);
        var result = codec.Deserialize(data);
        Assert.Equal(new int?[] { 1 }, TreeToList(result));
    }

    [Fact]
    public void LeftSkewed()
    {
        var codec = new Codec();
        var root = BuildTree([1, 2, null, 3]);
        var data = codec.Serialize(root);
        var result = codec.Deserialize(data);
        Assert.Equal(new int?[] { 1, 2, null, 3 }, TreeToList(result));
    }

    [Fact]
    public void CompleteTree()
    {
        var codec = new Codec();
        var root = BuildTree([1, 2, 3, 4, 5, 6, 7]);
        var data = codec.Serialize(root);
        var result = codec.Deserialize(data);
        Assert.Equal(new int?[] { 1, 2, 3, 4, 5, 6, 7 }, TreeToList(result));
    }

    [Fact]
    public void NegativeValues()
    {
        var codec = new Codec();
        var root = BuildTree([-1, -2, -3]);
        var data = codec.Serialize(root);
        var result = codec.Deserialize(data);
        Assert.Equal(new int?[] { -1, -2, -3 }, TreeToList(result));
    }
}
