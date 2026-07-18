from solutions import build_tree
from solutions.trees.easy.maximum_depth_of_binary_tree import MaximumDepthOfBinaryTree


class TestMaximumDepthOfBinaryTree:
    def setup_method(self):
        self.sol = MaximumDepthOfBinaryTree()

    def test_example1(self):
        root = build_tree([3, 9, 20, None, None, 15, 7])
        assert self.sol.max_depth(root) == 3

    def test_example2(self):
        root = build_tree([1, None, 2])
        assert self.sol.max_depth(root) == 2

    def test_empty_tree(self):
        assert self.sol.max_depth(None) == 0

    def test_single_node(self):
        root = build_tree([1])
        assert self.sol.max_depth(root) == 1

    def test_balanced(self):
        root = build_tree([1, 2, 3, 4, 5, 6, 7])
        assert self.sol.max_depth(root) == 3

    def test_left_skewed(self):
        root = build_tree([1, 2, None, 3, None, 4])
        assert self.sol.max_depth(root) == 4

    def test_right_skewed(self):
        root = build_tree([1, None, 2, None, 3])
        assert self.sol.max_depth(root) == 3
