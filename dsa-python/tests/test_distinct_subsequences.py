from solutions.dp_2d.hard.distinct_subsequences import DistinctSubsequences


class TestDistinctSubsequences:
    def setup_method(self):
        self.sol = DistinctSubsequences()

    def test_example1(self):
        assert self.sol.num_distinct("rabbbit", "rabbit") == 3

    def test_example2(self):
        assert self.sol.num_distinct("babgbag", "bag") == 5

    def test_no_match(self):
        assert self.sol.num_distinct("abc", "def") == 0

    def test_empty_t(self):
        assert self.sol.num_distinct("abc", "") == 1

    def test_t_longer_than_s(self):
        assert self.sol.num_distinct("ab", "abc") == 0

    def test_same_strings(self):
        assert self.sol.num_distinct("abc", "abc") == 1

    def test_single_char(self):
        assert self.sol.num_distinct("aaa", "a") == 3

    def test_repeated_pattern(self):
        assert self.sol.num_distinct("aabb", "ab") == 4
