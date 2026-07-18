from solutions import build_tree
from solutions.trees.medium.lowest_common_ancestor_of_a_binary_search_tree import (
    LowestCommonAncestorOfABinarySearchTree,
    TreeNode,
)


def find_node(root: TreeNode | None, val: int) -> TreeNode | None:
    """Find a node with given value in the tree."""
    if root is None:
        return None
    if root.val == val:
        return root
    left = find_node(root.left, val)
    if left:
        return left
    return find_node(root.right, val)


class TestLowestCommonAncestorOfABinarySearchTree:
    def setup_method(self):
        self.sol = LowestCommonAncestorOfABinarySearchTree()

    def test_example1(self):
        root = build_tree([6, 2, 8, 0, 4, 7, 9, None, None, 3, 5])
        p = find_node(root, 2)
        q = find_node(root, 8)
        assert self.sol.lowest_common_ancestor(root, p, q).val == 6

    def test_example2(self):
        root = build_tree([6, 2, 8, 0, 4, 7, 9, None, None, 3, 5])
        p = find_node(root, 2)
        q = find_node(root, 4)
        assert self.sol.lowest_common_ancestor(root, p, q).val == 2

    def test_example3(self):
        root = build_tree([2, 1])
        p = find_node(root, 2)
        q = find_node(root, 1)
        assert self.sol.lowest_common_ancestor(root, p, q).val == 2

    def test_both_in_right(self):
        root = build_tree([6, 2, 8, 0, 4, 7, 9])
        p = find_node(root, 7)
        q = find_node(root, 9)
        assert self.sol.lowest_common_ancestor(root, p, q).val == 8

    def test_both_in_left(self):
        root = build_tree([6, 2, 8, 0, 4, 7, 9])
        p = find_node(root, 0)
        q = find_node(root, 4)
        assert self.sol.lowest_common_ancestor(root, p, q).val == 2

    def test_root_is_lca(self):
        root = build_tree([5, 3, 7, 1, 4, 6, 8])
        p = find_node(root, 1)
        q = find_node(root, 8)
        assert self.sol.lowest_common_ancestor(root, p, q).val == 5
