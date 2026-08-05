// 572. Subtree of Another Tree
// https://leetcode.com/problems/subtree-of-another-tree/
//
// Given the roots of two binary trees root and subRoot, return true if there
// is a subtree of root with the same structure and node values of subRoot.
//
// APPROACH: DFS through root. At each node, check if subtree matches using IsSameTree. If any match → true.
//
// TIME: O(m*n) worst case
// SPACE: O(h)

public class SubtreeOfAnotherTree
{
    public bool IsSubtree(TreeNode? root, TreeNode? subRoot)
    {
        if(root == null) return false;
        if(IsSameTree(root, subRoot)) return true;
        return IsSubtree(root.left , subRoot) || IsSubtree(root.right,subRoot);
    }

    private bool IsSameTree(TreeNode? p, TreeNode? q)
    {
        if(p == null && q== null) return true;
        if(p == null || q == null) return false;
        return (p.val == q.val) && IsSameTree(p.left,q.left) && IsSameTree(p.right,q.right);
    }
}
