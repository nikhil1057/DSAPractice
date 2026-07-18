from solutions.backtracking.medium.permutations import Permutations


class TestPermutations:
    def setup_method(self):
        self.sol = Permutations()

    def test_example1(self):
        result = self.sol.permute([1, 2, 3])
        expected = [[1, 2, 3], [1, 3, 2], [2, 1, 3], [2, 3, 1], [3, 1, 2], [3, 2, 1]]
        assert sorted(result) == sorted(expected)

    def test_example2(self):
        result = self.sol.permute([0, 1])
        expected = [[0, 1], [1, 0]]
        assert sorted(result) == sorted(expected)

    def test_example3(self):
        result = self.sol.permute([1])
        assert result == [[1]]

    def test_two_elements(self):
        result = self.sol.permute([5, 10])
        expected = [[5, 10], [10, 5]]
        assert sorted(result) == sorted(expected)

    def test_four_elements(self):
        result = self.sol.permute([1, 2, 3, 4])
        assert len(result) == 24  # 4! = 24

    def test_negative_numbers(self):
        result = self.sol.permute([-1, 0, 1])
        assert len(result) == 6  # 3! = 6

    def test_no_duplicates_in_result(self):
        result = self.sol.permute([1, 2, 3])
        # Ensure all permutations are unique
        result_tuples = [tuple(r) for r in result]
        assert len(result_tuples) == len(set(result_tuples))
