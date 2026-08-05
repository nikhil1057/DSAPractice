# 235. Lowest Common Ancestor of a Binary Search Tree
# https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/
#
# Given a binary search tree (BST), find the lowest common ancestor (LCA) node
# of two given nodes in the BST.
# The lowest common ancestor is defined between two nodes p and q as the lowest
# node in T that has both p and q as descendants (where we allow a node to be
# a descendant of itself).
#
# APPROACH: Use BST property. At each node:
# - Both p and q are smaller → LCA is in left subtree
# - Both p and q are bigger → LCA is in right subtree
# - One on each side (or one equals current) → current IS the LCA
#
# TIME: O(h) — traverse height of tree
# SPACE: O(1) — iterative


class TreeNode:
    def __init__(self, val: int = 0, left: "TreeNode | None" = None, right: "TreeNode | None" = None):
        self.val = val
        self.left = left
        self.right = right


class LowestCommonAncestorOfABinarySearchTree:
    def lowest_common_ancestor(self, root: TreeNode, p: TreeNode, q: TreeNode) -> TreeNode:
        if not root: return None
        if p.val < root.val and q.val < root.val: return self.lowest_common_ancestor(root.left, p, q)
        elif p.val > root.val and q.val > root.val: return self.lowest_common_ancestor(root.right, p, q)
        else: return root
