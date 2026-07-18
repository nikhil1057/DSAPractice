from solutions.backtracking.medium.subsets import Subsets


class TestSubsets:
    def setup_method(self):
        self.sol = Subsets()

    def test_example1(self):
        result = self.sol.subsets([1, 2, 3])
        expected = [[], [1], [2], [1, 2], [3], [1, 3], [2, 3], [1, 2, 3]]
        assert sorted([sorted(s) for s in result]) == sorted([sorted(s) for s in expected])

    def test_example2(self):
        result = self.sol.subsets([0])
        expected = [[], [0]]
        assert sorted([sorted(s) for s in result]) == sorted([sorted(s) for s in expected])

    def test_empty_input(self):
        # Single element already tested, test two elements
        result = self.sol.subsets([1, 2])
        expected = [[], [1], [2], [1, 2]]
        assert sorted([sorted(s) for s in result]) == sorted([sorted(s) for s in expected])

    def test_negative_numbers(self):
        result = self.sol.subsets([-1, 0, 1])
        assert len(result) == 8  # 2^3 = 8 subsets

    def test_single_negative(self):
        result = self.sol.subsets([-5])
        expected = [[], [-5]]
        assert sorted([sorted(s) for s in result]) == sorted([sorted(s) for s in expected])

    def test_length(self):
        # 4 elements -> 2^4 = 16 subsets
        result = self.sol.subsets([1, 2, 3, 4])
        assert len(result) == 16
