// 1448. Count Good Nodes in Binary Tree
// https://leetcode.com/problems/count-good-nodes-in-binary-tree/
//
// Given a binary tree root, a node X is "good" if no node on the path from
// root to X has a value greater than X. Return the count of good nodes.
//
// APPROACH: DFS, carry maxSoFar (max value on path from root to current node).
// If node.val >= maxSoFar → it's a good node (no greater value above it).
// Update maxSoFar and recurse on children.
//
// TIME: O(n) — visit every node once
// SPACE: O(h) — recursion stack

public class CountGoodNodesInBinaryTree
{
    public int GoodNodes(TreeNode root)
    {
        int count = 0;
        if(root == null) return count;

        dfs(root, root.val, ref count);

        return count;

    }

    private void dfs(TreeNode root, int maxSoFar, ref int count)
    {
        if(root == null) return;

        if(maxSoFar <= root.val) count++;

        int newMax = Math.Max(maxSoFar,root.val);

        dfs(root.left, newMax, ref count);
        dfs(root.right, newMax, ref count);
    }
}
