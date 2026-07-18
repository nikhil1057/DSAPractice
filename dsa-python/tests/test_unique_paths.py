from solutions.dp_2d.medium.unique_paths import UniquePaths


class TestUniquePaths:
    def setup_method(self):
        self.sol = UniquePaths()

    def test_example1(self):
        # 3x7 grid => 28
        assert self.sol.unique_paths(3, 7) == 28

    def test_example2(self):
        # 3x2 grid => 3
        assert self.sol.unique_paths(3, 2) == 3

    def test_1x1_grid(self):
        assert self.sol.unique_paths(1, 1) == 1

    def test_1xn_grid(self):
        # Only one path (all right)
        assert self.sol.unique_paths(1, 5) == 1

    def test_nx1_grid(self):
        # Only one path (all down)
        assert self.sol.unique_paths(5, 1) == 1

    def test_2x2_grid(self):
        assert self.sol.unique_paths(2, 2) == 2

    def test_3x3_grid(self):
        assert self.sol.unique_paths(3, 3) == 6

    def test_large_grid(self):
        # 7x3 should equal 3x7 = 28
        assert self.sol.unique_paths(7, 3) == 28
