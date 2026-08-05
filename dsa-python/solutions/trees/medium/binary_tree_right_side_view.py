# 199. Binary Tree Right Side View
# https://leetcode.com/problems/binary-tree-right-side-view/
#
# Given the root of a binary tree, imagine yourself standing on the right side
# of it, return the values of the nodes you can see ordered from top to bottom.
#
# APPROACH: BFS level by level (same as Level Order Traversal).
# For each level, only the LAST node is visible from the right side.
# So just take level[-1] instead of the whole level.
#
# TIME: O(n) — visit every node once
# SPACE: O(n) — queue can hold up to n/2 nodes

from collections import deque


class TreeNode:
    def __init__(self, val: int = 0, left: "TreeNode | None" = None, right: "TreeNode | None" = None):
        self.val = val
        self.left = left
        self.right = right


class BinaryTreeRightSideView:
    def right_side_view(self, root: TreeNode | None) -> list[int]:
        if not root:
            return []

        result = []
        queue = deque([root])

        while queue:
            level_size = len(queue)

            for i in range(level_size):
                node = queue.popleft()

                # Last node in this level = rightmost visible
                if i == level_size - 1:
                    result.append(node.val)

                if node.left: queue.append(node.left)
                if node.right: queue.append(node.right)

        return result
