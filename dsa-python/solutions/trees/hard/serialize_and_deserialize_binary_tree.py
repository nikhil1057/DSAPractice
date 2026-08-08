# 297. Serialize and Deserialize Binary Tree
# https://leetcode.com/problems/serialize-and-deserialize-binary-tree/
#
# Design an algorithm to serialize and deserialize a binary tree.
#
# APPROACH: Preorder DFS with "null" markers for empty nodes.
# Serialize: preorder traversal, append "null" for None nodes, join by comma.
# Deserialize: split by comma, read values one by one, recursively build
# left then right. "null" means return None (subtree is done).
#
# Single preorder + null markers is enough to uniquely reconstruct the tree.
#
# TIME: O(n) — visit every node once for both serialize and deserialize
# SPACE: O(n) — storing the serialized string / recursion stack


class TreeNode:
    def __init__(self, val: int = 0, left: "TreeNode | None" = None, right: "TreeNode | None" = None):
        self.val = val
        self.left = left
        self.right = right


class Codec:
    def serialize(self, root: TreeNode | None) -> str:
        result = []

        def dfs(node):
            if not node:
                result.append("null")
                return
            result.append(str(node.val))  # convert to string for join
            dfs(node.left)
            dfs(node.right)

        dfs(root)
        return ','.join(result)

    def deserialize(self, data: str) -> TreeNode | None:
        values = data.split(",")
        index = 0

        def dfs():
            nonlocal index
            if values[index] == "null":
                index += 1
                return None

            node = TreeNode(int(values[index]))
            index += 1
            node.left = dfs()
            node.right = dfs()
            return node

        return dfs()
