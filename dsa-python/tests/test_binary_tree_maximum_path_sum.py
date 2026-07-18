from solutions import build_tree
from solutions.trees.hard.binary_tree_maximum_path_sum import BinaryTreeMaximumPathSum


class TestBinaryTreeMaximumPathSum:
    def setup_method(self):
        self.sol = BinaryTreeMaximumPathSum()

    def test_example1(self):
        root = build_tree([1, 2, 3])
        assert self.sol.max_path_sum(root) == 6

    def test_example2(self):
        root = build_tree([-10, 9, 20, None, None, 15, 7])
        assert self.sol.max_path_sum(root) == 42

    def test_single_node(self):
        root = build_tree([1])
        assert self.sol.max_path_sum(root) == 1

    def test_single_negative(self):
        root = build_tree([-3])
        assert self.sol.max_path_sum(root) == -3

    def test_all_negative(self):
        root = build_tree([-1, -2, -3])
        assert self.sol.max_path_sum(root) == -1

    def test_left_path_only(self):
        root = build_tree([1, 2, -1])
        assert self.sol.max_path_sum(root) == 3

    def test_complex(self):
        root = build_tree([5, 4, 8, 11, None, 13, 4, 7, 2, None, None, None, 1])
        assert self.sol.max_path_sum(root) == 48
