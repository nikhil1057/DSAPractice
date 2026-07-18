from solutions.binary_search.medium.koko_eating_bananas import KokoEatingBananas


class TestKokoEatingBananas:
    def setup_method(self):
        self.sol = KokoEatingBananas()

    def test_example1(self):
        # piles=[3,6,7,11], h=8 → 4
        assert self.sol.min_eating_speed([3, 6, 7, 11], 8) == 4

    def test_example2(self):
        # piles=[30,11,23,4,20], h=5 → 30
        assert self.sol.min_eating_speed([30, 11, 23, 4, 20], 5) == 30

    def test_example3(self):
        # piles=[30,11,23,4,20], h=6 → 23
        assert self.sol.min_eating_speed([30, 11, 23, 4, 20], 6) == 23

    def test_single_pile(self):
        # piles=[10], h=5 → 2
        assert self.sol.min_eating_speed([10], 5) == 2

    def test_h_equals_piles(self):
        # piles=[3,6,7,11], h=4 → 11 (must eat each pile in one hour)
        assert self.sol.min_eating_speed([3, 6, 7, 11], 4) == 11

    def test_large_h(self):
        # piles=[1,1,1,1], h=100 → 1
        assert self.sol.min_eating_speed([1, 1, 1, 1], 100) == 1

    def test_all_same_piles(self):
        # piles=[5,5,5], h=3 → 5
        assert self.sol.min_eating_speed([5, 5, 5], 3) == 5
