from solutions.array_and_hashing.medium.top_k_frequent_elements import TopKFrequentElements


class TestTopKFrequentElements:
    def setup_method(self):
        self.sol = TopKFrequentElements()

    def test_example1(self):
        # [1,1,1,2,2,3], k=2 => [1,2]
        result = self.sol.top_k_frequent([1, 1, 1, 2, 2, 3], 2)
        assert sorted(result) == [1, 2]

    def test_example2(self):
        # [1], k=1 => [1]
        result = self.sol.top_k_frequent([1], 1)
        assert result == [1]

    def test_all_same_frequency(self):
        # [1,2,3], k=3 => [1,2,3]
        result = self.sol.top_k_frequent([1, 2, 3], 3)
        assert sorted(result) == [1, 2, 3]

    def test_negative_numbers(self):
        # [-1,-1,2,2,3], k=2 => [-1,2]
        result = self.sol.top_k_frequent([-1, -1, 2, 2, 3], 2)
        assert sorted(result) == [-1, 2]

    def test_single_element_repeated(self):
        # [5,5,5,5], k=1 => [5]
        result = self.sol.top_k_frequent([5, 5, 5, 5], 1)
        assert result == [5]

    def test_k_equals_array_length(self):
        # [1,2,3,4], k=4 => [1,2,3,4]
        result = self.sol.top_k_frequent([1, 2, 3, 4], 4)
        assert sorted(result) == [1, 2, 3, 4]
