# 124. Binary Tree Maximum Path Sum
# https://leetcode.com/problems/binary-tree-maximum-path-sum/
#
# Given the root of a binary tree, return the maximum path sum of any non-empty path.
# A path can start and end at any node.
#
# APPROACH: Postorder recursion (same pattern as Diameter).
# At each node, compute best path THROUGH it: left_gain + node.val + right_gain.
# Track global max. Return best single-direction gain to parent (path can't fork).
# Ignore negative subtrees (max(0, gain)) — they only hurt the total.
#
# TIME: O(n) — visit every node once
# SPACE: O(h) — recursion stack


class TreeNode:
    def __init__(self, val: int = 0, left: "TreeNode | None" = None, right: "TreeNode | None" = None):
        self.val = val
        self.left = left
        self.right = right


class BinaryTreeMaximumPathSum:
    def max_path_sum(self, root: TreeNode | None) -> int:
        max_path = float('-inf')

        def max_gain(node):
            nonlocal max_path
            if not node:
                return 0

            left = max(0, max_gain(node.left))    # ignore negative subtrees
            right = max(0, max_gain(node.right))

            # Path through this node (can use both branches)
            max_path = max(max_path, left + node.val + right)

            # Return to parent: can only go one direction (path can't fork)
            return node.val + max(left, right)

        max_gain(root)
        return max_path
