from solutions.array_and_hashing.easy.majority_element import MajorityElement


class TestMajorityElement:
    def setup_method(self):
        self.sol = MajorityElement()

    def test_example1(self):
        # [3,2,3] => 3
        assert self.sol.majority_element([3, 2, 3]) == 3

    def test_example2(self):
        # [2,2,1,1,1,2,2] => 2
        assert self.sol.majority_element([2, 2, 1, 1, 1, 2, 2]) == 2

    def test_single_element(self):
        assert self.sol.majority_element([1]) == 1

    def test_two_elements_same(self):
        assert self.sol.majority_element([5, 5]) == 5

    def test_all_same(self):
        assert self.sol.majority_element([7, 7, 7, 7, 7]) == 7

    def test_majority_at_end(self):
        # [1,2,3,3,3] => 3
        assert self.sol.majority_element([1, 2, 3, 3, 3]) == 3
