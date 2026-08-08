// 124. Binary Tree Maximum Path Sum
// https://leetcode.com/problems/binary-tree-maximum-path-sum/
//
// Given the root of a binary tree, return the maximum path sum of any non-empty path.
//
// APPROACH: Postorder recursion (same pattern as Diameter).
// At each node, compute best path THROUGH it: left_gain + node.val + right_gain.
// Track global max. Return best single-direction gain to parent (path can't fork).
// Ignore negative subtrees (max(0, gain)) — they only hurt the total.
// Init maxPath to int.MinValue to handle all-negative trees.
//
// TIME: O(n) — visit every node once
// SPACE: O(h) — recursion stack

public class BinaryTreeMaximumPathSum
{
    public int MaxPathSum(TreeNode? root)
    {
       int maxPath = int.MinValue;

       maxGain(root, ref maxPath);

       return maxPath;
    }

    private int maxGain(TreeNode? root, ref int maxPath)
    {
        if(root == null) return 0;

        int left = Math.Max(maxGain(root.left, ref maxPath), 0);
        int right = Math.Max(maxGain(root.right, ref maxPath), 0);

        maxPath = Math.Max(maxPath,left + root.val + right);

        return root.val + Math.Max(left,right);
    }
}
