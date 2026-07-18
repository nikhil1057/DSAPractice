# 1448. Count Good Nodes in Binary Tree
# https://leetcode.com/problems/count-good-nodes-in-binary-tree/
#
# Given a binary tree root, a node X in the tree is named good if in the path
# from root to X there are no nodes with a value greater than X.
# Return the number of good nodes in the binary tree.
#
# Example 1: Input: root = [3,1,4,3,null,1,5] Output: 4
#   (Root 3 is always good. Node 4 > 3. Node 5 > 4 > 3. Node 3 in left = 3.)
# Example 2: Input: root = [3,3,null,4,2] Output: 3
# Example 3: Input: root = [1] Output: 1
#
# Constraints:
# - The number of nodes in the binary tree is in the range [1, 10^5].
# - Each node's value is between [-10^4, 10^4].


class TreeNode:
    def __init__(self, val: int = 0, left: "TreeNode | None" = None, right: "TreeNode | None" = None):
        self.val = val
        self.left = left
        self.right = right


class CountGoodNodesInBinaryTree:
    def good_nodes(self, root: TreeNode) -> int:
        pass
