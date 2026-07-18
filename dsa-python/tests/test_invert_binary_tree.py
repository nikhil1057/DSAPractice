from solutions import build_tree, tree_to_list
from solutions.trees.easy.invert_binary_tree import InvertBinaryTree


class TestInvertBinaryTree:
    def setup_method(self):
        self.sol = InvertBinaryTree()

    def test_example1(self):
        root = build_tree([4, 2, 7, 1, 3, 6, 9])
        result = self.sol.invert_tree(root)
        assert tree_to_list(result) == [4, 7, 2, 9, 6, 3, 1]

    def test_example2(self):
        root = build_tree([2, 1, 3])
        result = self.sol.invert_tree(root)
        assert tree_to_list(result) == [2, 3, 1]

    def test_empty_tree(self):
        assert self.sol.invert_tree(None) is None

    def test_single_node(self):
        root = build_tree([1])
        result = self.sol.invert_tree(root)
        assert tree_to_list(result) == [1]

    def test_left_skewed(self):
        root = build_tree([1, 2, None, 3])
        result = self.sol.invert_tree(root)
        assert tree_to_list(result) == [1, None, 2, None, 3]

    def test_right_skewed(self):
        root = build_tree([1, None, 2, None, 3])
        result = self.sol.invert_tree(root)
        assert tree_to_list(result) == [1, 2, None, 3]
