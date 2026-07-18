from solutions import build_tree
from solutions.trees.easy.diameter_of_binary_tree import DiameterOfBinaryTree


class TestDiameterOfBinaryTree:
    def setup_method(self):
        self.sol = DiameterOfBinaryTree()

    def test_example1(self):
        root = build_tree([1, 2, 3, 4, 5])
        assert self.sol.diameter_of_binary_tree(root) == 3

    def test_example2(self):
        root = build_tree([1, 2])
        assert self.sol.diameter_of_binary_tree(root) == 1

    def test_single_node(self):
        root = build_tree([1])
        assert self.sol.diameter_of_binary_tree(root) == 0

    def test_balanced(self):
        root = build_tree([1, 2, 3, 4, 5, 6, 7])
        assert self.sol.diameter_of_binary_tree(root) == 4

    def test_left_heavy(self):
        root = build_tree([1, 2, None, 3, None, 4])
        assert self.sol.diameter_of_binary_tree(root) == 3

    def test_diameter_not_through_root(self):
        # Tree where diameter goes through a non-root node
        root = build_tree([1, 2, 3, 4, 5, None, None, None, None, 6, 7])
        assert self.sol.diameter_of_binary_tree(root) == 4
