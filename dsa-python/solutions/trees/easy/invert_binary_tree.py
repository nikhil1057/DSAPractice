# 226. Invert Binary Tree
# https://leetcode.com/problems/invert-binary-tree/
#
# Given the root of a binary tree, invert the tree, and return its root.
#
# APPROACH: Recursion (preorder). At each node, swap left and right children,
# then recurse on both. Every subtree gets mirrored.
#
# TIME: O(n) — visit every node once
# SPACE: O(h) — recursion stack (h = height, worst case O(n) for skewed tree)


class TreeNode:
    def __init__(self, val: int = 0, left: "TreeNode | None" = None, right: "TreeNode | None" = None):
        self.val = val
        self.left = left
        self.right = right


class InvertBinaryTree:
    def invert_tree(self, root: TreeNode | None) -> TreeNode | None:
        if not root:
            return None

        # Swap left and right children
        root.left, root.right = root.right, root.left

        # Recurse on both subtrees
        self.invert_tree(root.left)
        self.invert_tree(root.right)

        return root
