# 572. Subtree of Another Tree
# https://leetcode.com/problems/subtree-of-another-tree/
#
# Given the roots of two binary trees root and subRoot, return true if there
# is a subtree of root with the same structure and node values of subRoot
# and false otherwise.
#
# A subtree of a binary tree is a tree that consists of a node in tree and
# all of this node's descendants.
#
# APPROACH: DFS through root. At each node, check if subtree matches using IsSameTree. If any match → true.
#
# TIME: O(m*n) worst case
# SPACE: O(h)


class TreeNode:
    def __init__(self, val: int = 0, left: "TreeNode | None" = None, right: "TreeNode | None" = None):
        self.val = val
        self.left = left
        self.right = right


class SubtreeOfAnotherTree:
    def is_same_tree(self, p: TreeNode | None, q: TreeNode | None) -> bool:
        if not p and not q: return True
        if not p or not q: return False
        return (p.val == q.val) and self.is_same_tree(p.left,q.left) and self.is_same_tree(p.right,q.right)
    def is_subtree(self, root: TreeNode | None, sub_root: TreeNode | None) -> bool:
        if not root:
            return False
        if self.is_same_tree(root, sub_root): return True
        return self.is_subtree(root.left,sub_root) or self.is_subtree(root.right, sub_root)
