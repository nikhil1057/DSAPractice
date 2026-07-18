from solutions.backtracking.medium.subsets_ii import SubsetsII


class TestSubsetsII:
    def setup_method(self):
        self.sol = SubsetsII()

    def test_example1(self):
        result = self.sol.subsets_with_dup([1, 2, 2])
        expected = [[], [1], [1, 2], [1, 2, 2], [2], [2, 2]]
        assert sorted([sorted(s) for s in result]) == sorted([sorted(s) for s in expected])

    def test_example2(self):
        result = self.sol.subsets_with_dup([0])
        expected = [[], [0]]
        assert sorted([sorted(s) for s in result]) == sorted([sorted(s) for s in expected])

    def test_all_duplicates(self):
        result = self.sol.subsets_with_dup([1, 1, 1])
        expected = [[], [1], [1, 1], [1, 1, 1]]
        assert sorted([sorted(s) for s in result]) == sorted([sorted(s) for s in expected])

    def test_no_duplicates(self):
        result = self.sol.subsets_with_dup([1, 2, 3])
        assert len(result) == 8  # Same as regular subsets

    def test_two_pairs(self):
        result = self.sol.subsets_with_dup([1, 1, 2, 2])
        expected = [[], [1], [1, 1], [1, 1, 2], [1, 1, 2, 2], [1, 2], [1, 2, 2], [2], [2, 2]]
        assert sorted([sorted(s) for s in result]) == sorted([sorted(s) for s in expected])

    def test_single_element(self):
        result = self.sol.subsets_with_dup([5])
        expected = [[], [5]]
        assert sorted([sorted(s) for s in result]) == sorted([sorted(s) for s in expected])
