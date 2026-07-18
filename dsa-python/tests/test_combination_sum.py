from solutions.backtracking.medium.combination_sum import CombinationSum


class TestCombinationSum:
    def setup_method(self):
        self.sol = CombinationSum()

    def test_example1(self):
        result = self.sol.combination_sum([2, 3, 6, 7], 7)
        expected = [[2, 2, 3], [7]]
        assert sorted([sorted(r) for r in result]) == sorted([sorted(e) for e in expected])

    def test_example2(self):
        result = self.sol.combination_sum([2, 3, 5], 8)
        expected = [[2, 2, 2, 2], [2, 3, 3], [3, 5]]
        assert sorted([sorted(r) for r in result]) == sorted([sorted(e) for e in expected])

    def test_example3(self):
        result = self.sol.combination_sum([2], 1)
        assert result == []

    def test_single_candidate_exact(self):
        result = self.sol.combination_sum([3], 9)
        expected = [[3, 3, 3]]
        assert sorted([sorted(r) for r in result]) == sorted([sorted(e) for e in expected])

    def test_single_candidate_not_divisible(self):
        result = self.sol.combination_sum([5], 7)
        assert result == []

    def test_target_equals_candidate(self):
        result = self.sol.combination_sum([1, 2], 2)
        expected = [[1, 1], [2]]
        assert sorted([sorted(r) for r in result]) == sorted([sorted(e) for e in expected])

    def test_large_candidates(self):
        result = self.sol.combination_sum([8, 7, 4, 3], 11)
        expected = [[3, 4, 4], [3, 8], [4, 7]]
        assert sorted([sorted(r) for r in result]) == sorted([sorted(e) for e in expected])
