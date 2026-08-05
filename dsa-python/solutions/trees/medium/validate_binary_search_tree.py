# 98. Validate Binary Search Tree
# https://leetcode.com/problems/validate-binary-search-tree/
#
# Given the root of a binary tree, determine if it is a valid binary search tree (BST).
# A valid BST is defined as follows:
# - The left subtree of a node contains only nodes with keys less than the node's key.
# - The right subtree of a node contains only nodes with keys greater than the node's key.
# - Both the left and right subtrees must also be binary search trees.
#
# APPROACH: DFS with min/max bounds. Pass valid range (-inf, +inf) down.
#           If node outside range, invalid. Left gets (min, node.val), right gets (node.val, max).
# TIME: O(n)
# SPACE: O(h)


class TreeNode:
    def __init__(self, val: int = 0, left: "TreeNode | None" = None, right: "TreeNode | None" = None):
        self.val = val
        self.left = left
        self.right = right


class ValidateBinarySearchTree:
    def is_valid_bst(self, root: TreeNode | None) -> bool:
        if not root: return True

        def isValid(node, min, max):
            if not node: return True
            if(node.val <= min or node.val >= max): return False
            return isValid(node.left, min, node.val) and isValid(node.right, node.val, max)
        return isValid(root, float('-inf'), float('inf'))
