# 110. Balanced Binary Tree
# https://leetcode.com/problems/balanced-binary-tree/
#
# Given a binary tree, determine if it is height-balanced.
# A height-balanced binary tree is a binary tree in which the depth of the
# two subtrees of every node never differs by more than one.
#
# APPROACH: Postorder recursion. Compute height at each node.
# If any node has |left_height - right_height| > 1, return -1 (unbalanced signal).
# If a child already returned -1, propagate it up (subtree below is unbalanced).
# At the end: -1 means unbalanced, anything else means balanced.
#
# TIME: O(n) — visit every node once
# SPACE: O(h) — recursion stack (h = height)


class TreeNode:
    def __init__(self, val: int = 0, left: "TreeNode | None" = None, right: "TreeNode | None" = None):
        self.val = val
        self.left = left
        self.right = right


class BalancedBinaryTree:
    def is_balanced(self, root: TreeNode | None) -> bool:
        def height(node):
            if not node:
                return 0

            left = height(node.left)    # height of left subtree
            right = height(node.right)  # height of right subtree

            if left == -1 or right == -1:  # child is already unbalanced
                return -1
            if abs(left - right) > 1:      # this node is unbalanced
                return -1

            return 1 + max(left, right)    # return height to parent

        return height(root) != -1  # -1 means unbalanced, != -1 means balanced
