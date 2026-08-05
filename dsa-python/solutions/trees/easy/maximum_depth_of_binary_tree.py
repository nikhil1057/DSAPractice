# 104. Maximum Depth of Binary Tree
# https://leetcode.com/problems/maximum-depth-of-binary-tree/
#
# Given the root of a binary tree, return its maximum depth.
#
# APPROACH: Recursion (postorder). Depth of a node = 1 + max(left depth, right depth).
# Base case: null node has depth 0.
#
# TIME: O(n) — visit every node once
# SPACE: O(h) — recursion stack (h = height)


class TreeNode:
    def __init__(self, val: int = 0, left: "TreeNode | None" = None, right: "TreeNode | None" = None):
        self.val = val
        self.left = left
        self.right = right


class MaximumDepthOfBinaryTree:
    def max_depth(self, root: TreeNode | None) -> int:
        if not root:
            return 0
        return 1 + max(self.max_depth(root.left), self.max_depth(root.right))
