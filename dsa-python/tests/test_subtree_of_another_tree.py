from solutions import build_tree
from solutions.trees.easy.subtree_of_another_tree import SubtreeOfAnotherTree


class TestSubtreeOfAnotherTree:
    def setup_method(self):
        self.sol = SubtreeOfAnotherTree()

    def test_example1(self):
        root = build_tree([3, 4, 5, 1, 2])
        sub_root = build_tree([4, 1, 2])
        assert self.sol.is_subtree(root, sub_root) is True

    def test_example2(self):
        root = build_tree([3, 4, 5, 1, 2, None, None, None, None, 0])
        sub_root = build_tree([4, 1, 2])
        assert self.sol.is_subtree(root, sub_root) is False

    def test_same_tree(self):
        root = build_tree([1, 2, 3])
        sub_root = build_tree([1, 2, 3])
        assert self.sol.is_subtree(root, sub_root) is True

    def test_single_node_match(self):
        root = build_tree([1, 2, 3])
        sub_root = build_tree([2])
        assert self.sol.is_subtree(root, sub_root) is True

    def test_single_node_no_match(self):
        root = build_tree([1, 2, 3])
        sub_root = build_tree([4])
        assert self.sol.is_subtree(root, sub_root) is False

    def test_null_root(self):
        sub_root = build_tree([1])
        assert self.sol.is_subtree(None, sub_root) is False

    def test_leaf_subtree(self):
        root = build_tree([1, 2, 3, 4, 5])
        sub_root = build_tree([2, 4, 5])
        assert self.sol.is_subtree(root, sub_root) is True
