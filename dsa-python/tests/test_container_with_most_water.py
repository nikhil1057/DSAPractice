from solutions.two_pointers.medium.container_with_most_water import ContainerWithMostWater


class TestContainerWithMostWater:
    def setup_method(self):
        self.sol = ContainerWithMostWater()

    def test_example1(self):
        # [1,8,6,2,5,4,8,3,7] => 49
        assert self.sol.max_area([1, 8, 6, 2, 5, 4, 8, 3, 7]) == 49

    def test_example2(self):
        # [1,1] => 1
        assert self.sol.max_area([1, 1]) == 1

    def test_decreasing_heights(self):
        # [5,4,3,2,1] => 6 (min(4,3)*2=6? Actually min(5,2)*3=6)
        assert self.sol.max_area([5, 4, 3, 2, 1]) == 6

    def test_increasing_heights(self):
        # [1,2,3,4,5] => 6
        assert self.sol.max_area([1, 2, 3, 4, 5]) == 6

    def test_same_heights(self):
        # [3,3,3,3] => 9
        assert self.sol.max_area([3, 3, 3, 3]) == 9

    def test_two_tall_ends(self):
        # [10,1,1,1,10] => 40
        assert self.sol.max_area([10, 1, 1, 1, 10]) == 40

    def test_single_peak(self):
        # [1,100,1] => 2
        assert self.sol.max_area([1, 100, 1]) == 2
