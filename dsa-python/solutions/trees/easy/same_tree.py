# 100. Same Tree
# https://leetcode.com/problems/same-tree/
#
# Given the roots of two binary trees p and q, write a function to check
# if they are the same or not. Two binary trees are considered the same
# if they are structurally identical, and the nodes have the same value.
#
# APPROACH: Recursion. Both null → true. One null → false. Values differ → false. Recurse left AND right.
#
# TIME: O(n)
# SPACE: O(h)


class TreeNode:
    def __init__(self, val: int = 0, left: "TreeNode | None" = None, right: "TreeNode | None" = None):
        self.val = val
        self.left = left
        self.right = right


class SameTree:
    def is_same_tree(self, p: TreeNode | None, q: TreeNode | None) -> bool:
        if not p and not q: return True
        if not p or not q: return False
        return (p.val == q.val) and self.is_same_tree(p.left, q.left) and self.is_same_tree(p.right, q.right)
