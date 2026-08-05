# 105. Construct Binary Tree from Preorder and Inorder Traversal
# https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
#
# Given two integer arrays preorder and inorder where preorder is the preorder
# traversal of a binary tree and inorder is the inorder traversal of the same
# tree, construct and return the binary tree.
#
# APPROACH: Preorder's first element = root. Find root in inorder (using HashMap
# for O(1) lookup) — everything left = left subtree, everything right = right subtree.
# Recurse. preIndex tracks current position in preorder (advances with each node created).
#
# BRUTE → OPTIMIZED: Brute scans inorder with for loop O(n) per node = O(n²).
# Optimized uses HashMap for O(1) lookup = O(n) total.
#
# TIME: O(n) — each node created once, O(1) lookup
# SPACE: O(n) — HashMap + recursion stack


class TreeNode:
    def __init__(self, val: int = 0, left: "TreeNode | None" = None, right: "TreeNode | None" = None):
        self.val = val
        self.left = left
        self.right = right


class ConstructBinaryTreeFromPreorderAndInorderTraversal:
    def build_tree(self, preorder: list[int], inorder: list[int]) -> TreeNode | None:
        inorder_map = {}
        for i in range(len(inorder)):
            inorder_map[inorder[i]] = i

        pre_index = 0

        def build(left, right):
            nonlocal pre_index
            if left > right:
                return None

            root_val = preorder[pre_index]
            pre_index += 1

            root = TreeNode(root_val)
            mid = inorder_map[root_val]

            root.left = build(left, mid - 1)
            root.right = build(mid + 1, right)

            return root

        return build(0, len(inorder) - 1)
