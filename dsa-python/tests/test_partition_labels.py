from solutions.greedy.medium.partition_labels import PartitionLabels


class TestPartitionLabels:
    def setup_method(self):
        self.sol = PartitionLabels()

    def test_example1(self):
        assert self.sol.partition_labels("ababcbacadefegdehijhklij") == [9, 7, 8]

    def test_example2(self):
        assert self.sol.partition_labels("eccbbbbdec") == [10]

    def test_single_char(self):
        assert self.sol.partition_labels("a") == [1]

    def test_all_unique(self):
        assert self.sol.partition_labels("abcdef") == [1, 1, 1, 1, 1, 1]

    def test_all_same(self):
        assert self.sol.partition_labels("aaaa") == [4]

    def test_two_partitions(self):
        assert self.sol.partition_labels("aabb") == [2, 2]

    def test_overlapping(self):
        assert self.sol.partition_labels("abab") == [4]
