from solutions.greedy.medium.jump_game_ii import JumpGameII


class TestJumpGameII:
    def setup_method(self):
        self.sol = JumpGameII()

    def test_example1(self):
        assert self.sol.jump([2, 3, 1, 1, 4]) == 2

    def test_example2(self):
        assert self.sol.jump([2, 3, 0, 1, 4]) == 2

    def test_single_element(self):
        assert self.sol.jump([0]) == 0

    def test_two_elements(self):
        assert self.sol.jump([1, 0]) == 1

    def test_all_ones(self):
        assert self.sol.jump([1, 1, 1, 1]) == 3

    def test_large_first_jump(self):
        assert self.sol.jump([5, 0, 0, 0, 0, 0]) == 1

    def test_optimal_greedy(self):
        assert self.sol.jump([1, 2, 3, 4, 5]) == 3
