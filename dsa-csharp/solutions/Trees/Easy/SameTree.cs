// 100. Same Tree
// https://leetcode.com/problems/same-tree/
//
// Given the roots of two binary trees p and q, write a function to check
// if they are the same or not. Two binary trees are considered the same
// if they are structurally identical, and the nodes have the same value.
//
// APPROACH: Recursion. Both null → true. One null → false. Values differ → false. Recurse left AND right.
//
// TIME: O(n)
// SPACE: O(h)

public class SameTree
{
    public bool IsSameTree(TreeNode? p, TreeNode? q)
    {
        if(p == null && q == null) return true;
        if(p == null || q == null) return false;
        return p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right,q.right);
    }
}
