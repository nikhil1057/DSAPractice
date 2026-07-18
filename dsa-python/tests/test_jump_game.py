from solutions.greedy.medium.jump_game import JumpGame


class TestJumpGame:
    def setup_method(self):
        self.sol = JumpGame()

    def test_example1(self):
        assert self.sol.can_jump([2, 3, 1, 1, 4]) is True

    def test_example2(self):
        assert self.sol.can_jump([3, 2, 1, 0, 4]) is False

    def test_single_element(self):
        assert self.sol.can_jump([0]) is True

    def test_two_elements_can(self):
        assert self.sol.can_jump([1, 0]) is True

    def test_two_elements_cannot(self):
        assert self.sol.can_jump([0, 1]) is False

    def test_all_ones(self):
        assert self.sol.can_jump([1, 1, 1, 1]) is True

    def test_large_first_jump(self):
        assert self.sol.can_jump([5, 0, 0, 0, 0, 0]) is True

    def test_zeros_in_middle(self):
        assert self.sol.can_jump([2, 0, 0]) is True
