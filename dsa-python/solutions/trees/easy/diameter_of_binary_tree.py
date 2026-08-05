# 543. Diameter of Binary Tree
# https://leetcode.com/problems/diameter-of-binary-tree/
#
# Given the root of a binary tree, return the length of the diameter of the tree.
# The diameter is the longest path between any two nodes (counted in edges).
# This path may or may not pass through the root.
#
# APPROACH: Postorder recursion. At each node, compute left and right heights.
# The path THROUGH this node = left_height + right_height.
# Track the max globally. Return height (1 + max(left, right)) to parent.
#
# TIME: O(n) — visit every node once
# SPACE: O(h) — recursion stack (h = height)


class TreeNode:
    def __init__(self, val: int = 0, left: "TreeNode | None" = None, right: "TreeNode | None" = None):
        self.val = val
        self.left = left
        self.right = right


class DiameterOfBinaryTree:
    def diameter_of_binary_tree(self, root: TreeNode | None) -> int:
        max_diameter = 0

        def height(node):
            nonlocal max_diameter
            if not node:
                return 0

            left = height(node.left)    # height of left subtree
            right = height(node.right)  # height of right subtree

            # Path through this node = left + right (update global max)
            max_diameter = max(max_diameter, left + right)

            # Return height of this node to parent
            return 1 + max(left, right)

        height(root)
        return max_diameter
