from solutions import build_tree
from solutions.trees.medium.binary_tree_right_side_view import BinaryTreeRightSideView


class TestBinaryTreeRightSideView:
    def setup_method(self):
        self.sol = BinaryTreeRightSideView()

    def test_example1(self):
        root = build_tree([1, 2, 3, None, 5, None, 4])
        assert self.sol.right_side_view(root) == [1, 3, 4]

    def test_example2(self):
        root = build_tree([1, None, 3])
        assert self.sol.right_side_view(root) == [1, 3]

    def test_empty_tree(self):
        assert self.sol.right_side_view(None) == []

    def test_single_node(self):
        root = build_tree([1])
        assert self.sol.right_side_view(root) == [1]

    def test_left_only(self):
        root = build_tree([1, 2, None, 3])
        assert self.sol.right_side_view(root) == [1, 2, 3]

    def test_complete_tree(self):
        root = build_tree([1, 2, 3, 4, 5, 6, 7])
        assert self.sol.right_side_view(root) == [1, 3, 7]

    def test_deeper_left(self):
        root = build_tree([1, 2, 3, 4])
        assert self.sol.right_side_view(root) == [1, 3, 4]
