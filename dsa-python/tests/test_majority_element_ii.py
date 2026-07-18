from solutions.array_and_hashing.medium.majority_element_ii import MajorityElementII


class TestMajorityElementII:
    def setup_method(self):
        self.sol = MajorityElementII()

    def test_example1(self):
        # [3,2,3] => [3]
        assert sorted(self.sol.majority_element([3, 2, 3])) == [3]

    def test_example2(self):
        # [1] => [1]
        assert sorted(self.sol.majority_element([1])) == [1]

    def test_example3(self):
        # [1,2] => [1,2]
        assert sorted(self.sol.majority_element([1, 2])) == [1, 2]

    def test_two_majority_elements(self):
        # [1,1,1,2,2,2,3] => [1,2]
        assert sorted(self.sol.majority_element([1, 1, 1, 2, 2, 2, 3])) == [1, 2]

    def test_no_majority(self):
        # [1,2,3,4] — no element appears > 4/3 = 1 time... actually each appears once which is not > 1
        assert sorted(self.sol.majority_element([1, 2, 3, 4])) == []

    def test_all_same(self):
        assert sorted(self.sol.majority_element([5, 5, 5, 5])) == [5]

    def test_exactly_one_third(self):
        # [1,1,2,2,3,3] — each appears 2 times, n/3 = 2, need > 2, so none qualify
        assert sorted(self.sol.majority_element([1, 1, 2, 2, 3, 3])) == []

    def test_single_element_repeated(self):
        assert sorted(self.sol.majority_element([0, 0, 0])) == [0]
