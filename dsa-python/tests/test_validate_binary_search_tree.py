from solutions import build_tree
from solutions.trees.medium.validate_binary_search_tree import ValidateBinarySearchTree


class TestValidateBinarySearchTree:
    def setup_method(self):
        self.sol = ValidateBinarySearchTree()

    def test_example1(self):
        root = build_tree([2, 1, 3])
        assert self.sol.is_valid_bst(root) is True

    def test_example2(self):
        root = build_tree([5, 1, 4, None, None, 3, 6])
        assert self.sol.is_valid_bst(root) is False

    def test_single_node(self):
        root = build_tree([1])
        assert self.sol.is_valid_bst(root) is True

    def test_equal_values(self):
        root = build_tree([2, 2, 2])
        assert self.sol.is_valid_bst(root) is False

    def test_valid_larger(self):
        root = build_tree([5, 3, 7, 2, 4, 6, 8])
        assert self.sol.is_valid_bst(root) is True

    def test_invalid_grandchild(self):
        # Right subtree has value less than root
        root = build_tree([5, 1, 6, None, None, 3, 7])
        assert self.sol.is_valid_bst(root) is False

    def test_left_skewed_valid(self):
        root = build_tree([3, 2, None, 1])
        assert self.sol.is_valid_bst(root) is True
