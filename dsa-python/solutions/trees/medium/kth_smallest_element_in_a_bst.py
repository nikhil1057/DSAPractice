# 230. Kth Smallest Element in a BST
# https://leetcode.com/problems/kth-smallest-element-in-a-bst/
#
# Given the root of a binary search tree, and an integer k, return the kth
# smallest value (1-indexed) of all the values of the nodes in the tree.
#
# APPROACH: Inorder traversal (Left → Root → Right) of a BST gives sorted order.
# Traverse inorder, counting nodes. When count == k, return that value.
# Use early exit: if left subtree already found the answer, bubble it up.
#
# TIME: O(k) — stop as soon as we find kth element (best case), O(n) worst case
# SPACE: O(h) — recursion stack (h = height)


class TreeNode:
    def __init__(self, val: int = 0, left: "TreeNode | None" = None, right: "TreeNode | None" = None):
        self.val = val
        self.left = left
        self.right = right


class KthSmallestElementInABst:
    def kth_smallest(self, root: TreeNode | None, k: int) -> int:
        count = 0

        def inorder(node):
            nonlocal count
            if not node:
                return None

            # Go left first (smaller values)
            left = inorder(node.left)
            if left is not None:
                return left  # found in left subtree, bubble up

            # Visit root — count it
            count += 1
            if count == k:
                return node.val  # found kth smallest!

            # Go right (larger values)
            return inorder(node.right)

        return inorder(root)
