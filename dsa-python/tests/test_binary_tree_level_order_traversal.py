from solutions import build_tree
from solutions.trees.medium.binary_tree_level_order_traversal import BinaryTreeLevelOrderTraversal


class TestBinaryTreeLevelOrderTraversal:
    def setup_method(self):
        self.sol = BinaryTreeLevelOrderTraversal()

    def test_example1(self):
        root = build_tree([3, 9, 20, None, None, 15, 7])
        assert self.sol.level_order(root) == [[3], [9, 20], [15, 7]]

    def test_example2(self):
        root = build_tree([1])
        assert self.sol.level_order(root) == [[1]]

    def test_empty_tree(self):
        assert self.sol.level_order(None) == []

    def test_two_levels(self):
        root = build_tree([1, 2, 3])
        assert self.sol.level_order(root) == [[1], [2, 3]]

    def test_left_skewed(self):
        root = build_tree([1, 2, None, 3])
        assert self.sol.level_order(root) == [[1], [2], [3]]

    def test_complete_tree(self):
        root = build_tree([1, 2, 3, 4, 5, 6, 7])
        assert self.sol.level_order(root) == [[1], [2, 3], [4, 5, 6, 7]]

    def test_unbalanced(self):
        root = build_tree([1, 2, 3, 4, None, None, 5])
        assert self.sol.level_order(root) == [[1], [2, 3], [4, 5]]
