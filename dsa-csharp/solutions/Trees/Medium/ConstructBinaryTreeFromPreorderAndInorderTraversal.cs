// 105. Construct Binary Tree from Preorder and Inorder Traversal
// https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
//
// Given two integer arrays preorder and inorder where preorder is the preorder
// traversal of a binary tree and inorder is the inorder traversal of the same
// tree, construct and return the binary tree.
//
// APPROACH: Preorder's first element = root. Find root in inorder using HashMap (O(1) lookup).
//           Everything left = left subtree, right = right subtree. Recurse with preIndex tracking position.
// TIME: O(n)
// SPACE: O(n)

public class ConstructBinaryTreeFromPreorderAndInorderTraversal
{
    public TreeNode? BuildTree(int[] preorder, int[] inorder)
    {
        Dictionary<int,int> inorderMap = new();

        for(int i = 0; i < inorder.Length; i++)
        {
            inorderMap[inorder[i]] = i;
        }

        int preIndex = 0;

        return build(preorder, inorderMap, 0, inorder.Length - 1, ref preIndex);
    }

    private TreeNode? build(int [] preorder, Dictionary<int,int> inorderMap, int left, int right, ref int preIndex)
    {
        if(left > right) return null;

        int rootValue = preorder[preIndex++];

        TreeNode root = new TreeNode(rootValue);

        int midValue = inorderMap[rootValue];

        root.left = build(preorder, inorderMap, left, midValue - 1, ref preIndex);
        root.right = build(preorder, inorderMap, midValue + 1, right, ref preIndex);

        return root;
    }
}
