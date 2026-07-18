from solutions import build_tree
from solutions.trees.easy.balanced_binary_tree import BalancedBinaryTree


class TestBalancedBinaryTree:
    def setup_method(self):
        self.sol = BalancedBinaryTree()

    def test_example1(self):
        root = build_tree([3, 9, 20, None, None, 15, 7])
        assert self.sol.is_balanced(root) is True

    def test_example2(self):
        root = build_tree([1, 2, 2, 3, 3, None, None, 4, 4])
        assert self.sol.is_balanced(root) is False

    def test_empty_tree(self):
        assert self.sol.is_balanced(None) is True

    def test_single_node(self):
        root = build_tree([1])
        assert self.sol.is_balanced(root) is True

    def test_left_skewed(self):
        root = build_tree([1, 2, None, 3])
        assert self.sol.is_balanced(root) is False

    def test_perfect_tree(self):
        root = build_tree([1, 2, 3, 4, 5, 6, 7])
        assert self.sol.is_balanced(root) is True

    def test_just_balanced(self):
        root = build_tree([1, 2, 3, 4])
        assert self.sol.is_balanced(root) is True
