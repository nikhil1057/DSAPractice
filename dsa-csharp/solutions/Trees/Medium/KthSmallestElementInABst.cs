// 230. Kth Smallest Element in a BST
// https://leetcode.com/problems/kth-smallest-element-in-a-bst/
//
// Given the root of a binary search tree, and an integer k, return the kth
// smallest value (1-indexed) of all the values of the nodes in the tree.
//
// APPROACH: Inorder traversal (Left → Root → Right) of a BST gives sorted order.
// Traverse inorder, counting nodes. When count == k, that's our answer.
// Use ref to share count and result across recursive calls (like Python's nonlocal).
//
// TIME: O(k) — stop as soon as we find kth element (best case), O(n) worst case
// SPACE: O(h) — recursion stack (h = height)

public class KthSmallestElementInABst
{
    public int KthSmallest(TreeNode? root, int k)
    {
        int count = 0;
        int result = 0;

        Inorder(root, k, ref count, ref result);

        return result;
    }

    private void Inorder(TreeNode? node, int k, ref int count, ref int result)
    {
        if (node == null) return;

        // Go left first (smaller values)
        Inorder(node.left, k, ref count, ref result);

        // Visit root — count it
        count++;
        if (count == k)
        {
            result = node.val;  // found kth smallest!
            return;
        }

        // Go right (larger values)
        Inorder(node.right, k, ref count, ref result);
    }
}
