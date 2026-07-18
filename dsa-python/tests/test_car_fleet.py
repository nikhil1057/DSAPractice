from solutions.stack.medium.car_fleet import CarFleet


class TestCarFleet:
    def setup_method(self):
        self.sol = CarFleet()

    def test_example1(self):
        # target=12, position=[10,8,0,5,3], speed=[2,4,1,1,3] → 3
        assert self.sol.car_fleet(12, [10, 8, 0, 5, 3], [2, 4, 1, 1, 3]) == 3

    def test_example2(self):
        # target=10, position=[3], speed=[3] → 1
        assert self.sol.car_fleet(10, [3], [3]) == 1

    def test_example3(self):
        # target=100, position=[0,2,4], speed=[4,2,1] → 1
        assert self.sol.car_fleet(100, [0, 2, 4], [4, 2, 1]) == 1

    def test_no_cars(self):
        assert self.sol.car_fleet(10, [], []) == 0

    def test_two_cars_same_speed(self):
        # Same speed, different positions → 2 fleets
        assert self.sol.car_fleet(10, [0, 5], [1, 1]) == 2

    def test_all_arrive_same_time(self):
        # target=10, position=[0,5], speed=[2,1] → both arrive at t=5 → 1 fleet
        assert self.sol.car_fleet(10, [0, 5], [2, 1]) == 1

    def test_cars_at_target(self):
        # target=10, position=[10], speed=[1] → already at target
        assert self.sol.car_fleet(10, [10], [1]) == 1
