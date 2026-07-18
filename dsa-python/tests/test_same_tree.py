from solutions import build_tree
from solutions.trees.easy.same_tree import SameTree


class TestSameTree:
    def setup_method(self):
        self.sol = SameTree()

    def test_example1(self):
        p = build_tree([1, 2, 3])
        q = build_tree([1, 2, 3])
        assert self.sol.is_same_tree(p, q) is True

    def test_example2(self):
        p = build_tree([1, 2])
        q = build_tree([1, None, 2])
        assert self.sol.is_same_tree(p, q) is False

    def test_example3(self):
        p = build_tree([1, 2, 1])
        q = build_tree([1, 1, 2])
        assert self.sol.is_same_tree(p, q) is False

    def test_both_empty(self):
        assert self.sol.is_same_tree(None, None) is True

    def test_one_empty(self):
        p = build_tree([1])
        assert self.sol.is_same_tree(p, None) is False

    def test_single_same(self):
        p = build_tree([1])
        q = build_tree([1])
        assert self.sol.is_same_tree(p, q) is True

    def test_different_values(self):
        p = build_tree([1, 2, 3])
        q = build_tree([1, 2, 4])
        assert self.sol.is_same_tree(p, q) is False
