from solutions.greedy.medium.merge_triplets_to_form_target_triplet import MergeTripletsToFormTargetTriplet


class TestMergeTripletsToFormTargetTriplet:
    def setup_method(self):
        self.sol = MergeTripletsToFormTargetTriplet()

    def test_example1(self):
        assert self.sol.merge_triplets([[2, 5, 3], [1, 8, 4], [1, 7, 5]], [2, 7, 5]) is True

    def test_example2(self):
        assert self.sol.merge_triplets([[3, 4, 5], [4, 5, 6]], [3, 2, 5]) is False

    def test_example3(self):
        assert self.sol.merge_triplets([[2, 5, 3], [2, 3, 4], [1, 2, 5], [5, 2, 3]], [5, 5, 5]) is True

    def test_single_triplet_match(self):
        assert self.sol.merge_triplets([[1, 2, 3]], [1, 2, 3]) is True

    def test_single_triplet_no_match(self):
        assert self.sol.merge_triplets([[1, 2, 3]], [1, 2, 4]) is False

    def test_all_exceed_one_value(self):
        assert self.sol.merge_triplets([[4, 1, 1], [1, 4, 1], [1, 1, 4]], [3, 3, 3]) is False

    def test_exact_match_needed(self):
        assert self.sol.merge_triplets([[1, 1, 1], [2, 2, 2], [3, 3, 3]], [3, 3, 3]) is True
