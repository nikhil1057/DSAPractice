// 543. Diameter of Binary Tree
// https://leetcode.com/problems/diameter-of-binary-tree/
//
// Given the root of a binary tree, return the length of the diameter.
// Diameter = longest path between any two nodes (counted in edges).
//
// APPROACH: Postorder recursion. At each node, compute left and right heights.
// Path THROUGH this node = left_height + right_height. Track max globally.
// Return height (1 + max(left, right)) to parent for its calculation.
//
// TIME: O(n) — visit every node once
// SPACE: O(h) — recursion stack (h = height)

public class DiameterOfBinaryTree
{
    public int DiameterOfBinaryTreeMethod(TreeNode? root)
    {
        int maxDiameter = 0;

        Height(root, ref maxDiameter);

        return maxDiameter;
    }

    private int Height(TreeNode? root, ref int maxDiameter)
    {
        if(root == null) return 0;

        int left = Height(root.left, ref maxDiameter);
        int right = Height(root.right, ref maxDiameter);

        maxDiameter = Math.Max(maxDiameter, left + right);

        return 1 + Math.Max(left, right);
    }
}
