from solutions import build_tree
from solutions.trees.medium.count_good_nodes_in_binary_tree import CountGoodNodesInBinaryTree


class TestCountGoodNodesInBinaryTree:
    def setup_method(self):
        self.sol = CountGoodNodesInBinaryTree()

    def test_example1(self):
        root = build_tree([3, 1, 4, 3, None, 1, 5])
        assert self.sol.good_nodes(root) == 4

    def test_example2(self):
        root = build_tree([3, 3, None, 4, 2])
        assert self.sol.good_nodes(root) == 3

    def test_example3(self):
        root = build_tree([1])
        assert self.sol.good_nodes(root) == 1

    def test_all_same_value(self):
        root = build_tree([3, 3, 3, 3, 3])
        assert self.sol.good_nodes(root) == 5

    def test_increasing_path(self):
        root = build_tree([1, None, 2, None, 3])
        assert self.sol.good_nodes(root) == 3

    def test_decreasing_path(self):
        root = build_tree([3, None, 2, None, 1])
        assert self.sol.good_nodes(root) == 1

    def test_negative_values(self):
        root = build_tree([-1, -2, -3])
        assert self.sol.good_nodes(root) == 1
