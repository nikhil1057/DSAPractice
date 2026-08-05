# 102. Binary Tree Level Order Traversal
# https://leetcode.com/problems/binary-tree-level-order-traversal/
#
# Given the root of a binary tree, return the level order traversal of its
# nodes' values (i.e., from left to right, level by level).
#
# APPROACH: BFS using a queue. Process nodes level by level.
# At each level, record size of queue (= nodes in this level),
# process exactly that many, and add their children for the next level.
#
# TIME: O(n) — visit every node once
# SPACE: O(n) — queue can hold up to n/2 nodes (widest level)

from collections import deque


class TreeNode:
    def __init__(self, val: int = 0, left: "TreeNode | None" = None, right: "TreeNode | None" = None):
        self.val = val
        self.left = left
        self.right = right


class BinaryTreeLevelOrderTraversal:
    def level_order(self, root: TreeNode | None) -> list[list[int]]:
        if not root:
            return []

        result = []
        queue = deque([root])

        while queue:
            level_size = len(queue)
            level = []

            for i in range(level_size):
                node = queue.popleft()
                level.append(node.val)

                if node.left: queue.append(node.left)
                if node.right: queue.append(node.right)

            result.append(level)

        return result
