from solutions.dp_1d.medium.partition_equal_subset_sum import PartitionEqualSubsetSum


class TestPartitionEqualSubsetSum:
    def setup_method(self):
        self.sol = PartitionEqualSubsetSum()

    def test_example1(self):
        assert self.sol.can_partition([1, 5, 11, 5]) is True

    def test_example2(self):
        assert self.sol.can_partition([1, 2, 3, 5]) is False

    def test_single_element(self):
        assert self.sol.can_partition([1]) is False

    def test_two_equal_elements(self):
        assert self.sol.can_partition([1, 1]) is True

    def test_two_unequal_elements(self):
        assert self.sol.can_partition([1, 2]) is False

    def test_all_zeros(self):
        assert self.sol.can_partition([0, 0, 0, 0]) is True

    def test_large_equal_partition(self):
        assert self.sol.can_partition([1, 2, 3, 4, 5, 5]) is True

    def test_odd_total_sum(self):
        assert self.sol.can_partition([1, 2, 4]) is False
