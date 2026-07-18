from solutions.two_pointers.medium.three_sum import ThreeSum


class TestThreeSum:
    def setup_method(self):
        self.sol = ThreeSum()

    def _sort_result(self, result):
        return sorted([sorted(triplet) for triplet in result])

    def test_example1(self):
        # [-1,0,1,2,-1,-4] => [[-1,-1,2],[-1,0,1]]
        result = self.sol.three_sum([-1, 0, 1, 2, -1, -4])
        expected = [[-1, -1, 2], [-1, 0, 1]]
        assert self._sort_result(result) == self._sort_result(expected)

    def test_example2(self):
        # [0,1,1] => []
        assert self.sol.three_sum([0, 1, 1]) == []

    def test_example3(self):
        # [0,0,0] => [[0,0,0]]
        result = self.sol.three_sum([0, 0, 0])
        assert result == [[0, 0, 0]]

    def test_no_triplets(self):
        assert self.sol.three_sum([1, 2, 3]) == []

    def test_multiple_triplets(self):
        result = self.sol.three_sum([-2, -1, 0, 1, 2])
        expected = [[-2, 0, 2], [-1, 0, 1]]
        assert self._sort_result(result) == self._sort_result(expected)

    def test_all_zeros(self):
        result = self.sol.three_sum([0, 0, 0, 0])
        assert result == [[0, 0, 0]]

    def test_two_elements(self):
        assert self.sol.three_sum([0, 0]) == []

    def test_empty(self):
        assert self.sol.three_sum([]) == []
