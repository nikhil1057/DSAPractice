// 297. Serialize and Deserialize Binary Tree
// https://leetcode.com/problems/serialize-and-deserialize-binary-tree/
//
// Design an algorithm to serialize and deserialize a binary tree.
//
// APPROACH: Preorder DFS with "null" markers for empty nodes.
// Serialize: preorder traversal, append "null" for null nodes, join by comma.
// Deserialize: split by comma, read values one by one, recursively build
// left then right. "null" means return null (subtree is done).
// Single preorder + null markers is enough to uniquely reconstruct the tree.
//
// TIME: O(n) — visit every node once for both serialize and deserialize
// SPACE: O(n) — storing the serialized string / recursion stack

public class Codec
{
    public string Serialize(TreeNode? root)
    {
        List<string> result = new();

       dfsCreate(root, result);

       return string.Join(",",result);
    }

    private void dfsCreate(TreeNode? root, List<string> result)
    {
        if(root == null)
        {
            result.Add("null");
            return;
        }

        result.Add(root.val.ToString());
        dfsCreate(root.left, result);
        dfsCreate(root.right, result);
    }

    public TreeNode? Deserialize(string data)
    {
        var values = data.Split(",").ToList();

        int index = 0;

        return dfsBreak(values, ref index);
    }

    private TreeNode? dfsBreak(List<string> values, ref int index)
    {
        if(values[index] == "null")
        {
            index++;
            return null;
        }

        TreeNode? node = new TreeNode(int.Parse(values[index++]));

        node.left = dfsBreak(values, ref index);
        node.right = dfsBreak(values, ref index);

        return node;
    }
}
