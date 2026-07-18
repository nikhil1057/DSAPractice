from solutions import build_tree, tree_to_list
from solutions.trees.medium.construct_binary_tree_from_preorder_and_inorder_traversal import (
    ConstructBinaryTreeFromPreorderAndInorderTraversal,
)


class TestConstructBinaryTreeFromPreorderAndInorderTraversal:
    def setup_method(self):
        self.sol = ConstructBinaryTreeFromPreorderAndInorderTraversal()

    def test_example1(self):
        result = self.sol.build_tree([3, 9, 20, 15, 7], [9, 3, 15, 20, 7])
        assert tree_to_list(result) == [3, 9, 20, None, None, 15, 7]

    def test_example2(self):
        result = self.sol.build_tree([-1], [-1])
        assert tree_to_list(result) == [-1]

    def test_left_skewed(self):
        result = self.sol.build_tree([3, 2, 1], [1, 2, 3])
        assert tree_to_list(result) == [3, 2, None, 1]

    def test_right_skewed(self):
        result = self.sol.build_tree([1, 2, 3], [1, 2, 3])
        assert tree_to_list(result) == [1, None, 2, None, 3]

    def test_complete_tree(self):
        result = self.sol.build_tree([1, 2, 4, 5, 3, 6, 7], [4, 2, 5, 1, 6, 3, 7])
        assert tree_to_list(result) == [1, 2, 3, 4, 5, 6, 7]

    def test_two_nodes(self):
        result = self.sol.build_tree([1, 2], [2, 1])
        assert tree_to_list(result) == [1, 2]
