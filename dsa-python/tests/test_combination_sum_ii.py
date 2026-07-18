from solutions.backtracking.medium.combination_sum_ii import CombinationSumII


class TestCombinationSumII:
    def setup_method(self):
        self.sol = CombinationSumII()

    def test_example1(self):
        result = self.sol.combination_sum2([10, 1, 2, 7, 6, 1, 5], 8)
        expected = [[1, 1, 6], [1, 2, 5], [1, 7], [2, 6]]
        assert sorted([sorted(r) for r in result]) == sorted([sorted(e) for e in expected])

    def test_example2(self):
        result = self.sol.combination_sum2([2, 5, 2, 1, 2], 5)
        expected = [[1, 2, 2], [5]]
        assert sorted([sorted(r) for r in result]) == sorted([sorted(e) for e in expected])

    def test_no_combination(self):
        result = self.sol.combination_sum2([3, 5, 7], 2)
        assert result == []

    def test_single_element_match(self):
        result = self.sol.combination_sum2([1], 1)
        expected = [[1]]
        assert sorted([sorted(r) for r in result]) == sorted([sorted(e) for e in expected])

    def test_single_element_no_match(self):
        result = self.sol.combination_sum2([2], 1)
        assert result == []

    def test_all_same_elements(self):
        result = self.sol.combination_sum2([2, 2, 2, 2], 4)
        expected = [[2, 2]]
        assert sorted([sorted(r) for r in result]) == sorted([sorted(e) for e in expected])

    def test_duplicates_in_result(self):
        result = self.sol.combination_sum2([1, 1, 1, 1, 1], 3)
        expected = [[1, 1, 1]]
        assert sorted([sorted(r) for r in result]) == sorted([sorted(e) for e in expected])
