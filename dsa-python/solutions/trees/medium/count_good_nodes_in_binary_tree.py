# 1448. Count Good Nodes in Binary Tree
# https://leetcode.com/problems/count-good-nodes-in-binary-tree/
#
# Given a binary tree root, a node X in the tree is named good if in the path
# from root to X there are no nodes with a value greater than X.
# Return the number of good nodes in the binary tree.
#
# APPROACH: DFS, carry maxSoFar (max value on path from root to current node).
# If node.val >= maxSoFar → it's a good node (no greater value above it).
# Update maxSoFar and recurse on children.
#
# TIME: O(n) — visit every node once
# SPACE: O(h) — recursion stack (h = height)


class TreeNode:
    def __init__(self, val: int = 0, left: "TreeNode | None" = None, right: "TreeNode | None" = None):
        self.val = val
        self.left = left
        self.right = right


class CountGoodNodesInBinaryTree:
    def good_nodes(self, root: TreeNode) -> int:
        if not root:
            return 0
        count = 0

        def dfs(node, maxSoFar):
            nonlocal count
            if not node:
                return

            if node.val >= maxSoFar:
                count += 1

            newMax = max(maxSoFar, node.val)
            dfs(node.left, newMax)
            dfs(node.right, newMax)

        dfs(root, root.val)
        return count
