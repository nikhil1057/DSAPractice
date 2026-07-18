from solutions import build_tree
from solutions.trees.medium.kth_smallest_element_in_a_bst import KthSmallestElementInABst


class TestKthSmallestElementInABst:
    def setup_method(self):
        self.sol = KthSmallestElementInABst()

    def test_example1(self):
        root = build_tree([3, 1, 4, None, 2])
        assert self.sol.kth_smallest(root, 1) == 1

    def test_example2(self):
        root = build_tree([5, 3, 6, 2, 4, None, None, 1])
        assert self.sol.kth_smallest(root, 3) == 3

    def test_single_node(self):
        root = build_tree([1])
        assert self.sol.kth_smallest(root, 1) == 1

    def test_k_equals_n(self):
        root = build_tree([3, 1, 4, None, 2])
        assert self.sol.kth_smallest(root, 4) == 4

    def test_left_skewed(self):
        root = build_tree([3, 2, None, 1])
        assert self.sol.kth_smallest(root, 2) == 2

    def test_right_skewed(self):
        root = build_tree([1, None, 2, None, 3])
        assert self.sol.kth_smallest(root, 3) == 3

    def test_large_k(self):
        root = build_tree([5, 3, 7, 2, 4, 6, 8])
        assert self.sol.kth_smallest(root, 5) == 6
