from solutions.greedy.medium.hand_of_straights import HandOfStraights


class TestHandOfStraights:
    def setup_method(self):
        self.sol = HandOfStraights()

    def test_example1(self):
        assert self.sol.is_n_straight_hand([1, 2, 3, 6, 2, 3, 4, 7, 8], 3) is True

    def test_example2(self):
        assert self.sol.is_n_straight_hand([1, 2, 3, 4, 5], 4) is False

    def test_group_size_one(self):
        assert self.sol.is_n_straight_hand([5, 1, 2], 1) is True

    def test_not_divisible(self):
        assert self.sol.is_n_straight_hand([1, 2, 3, 4, 5], 3) is False

    def test_single_group(self):
        assert self.sol.is_n_straight_hand([1, 2, 3], 3) is True

    def test_duplicates(self):
        assert self.sol.is_n_straight_hand([1, 1, 2, 2, 3, 3], 3) is True

    def test_gap_in_sequence(self):
        assert self.sol.is_n_straight_hand([1, 2, 4, 5, 6, 7], 3) is False

    def test_empty_hand(self):
        assert self.sol.is_n_straight_hand([], 3) is True
