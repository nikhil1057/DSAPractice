from solutions.heap.medium.task_scheduler import TaskScheduler


class TestTaskScheduler:
    def setup_method(self):
        self.sol = TaskScheduler()

    def test_example1(self):
        assert self.sol.least_interval(["A", "A", "A", "B", "B", "B"], 2) == 8

    def test_example2(self):
        assert self.sol.least_interval(["A", "C", "A", "B", "D", "B"], 1) == 6

    def test_example3(self):
        assert self.sol.least_interval(["A", "A", "A", "B", "B", "B"], 3) == 10

    def test_no_cooldown(self):
        assert self.sol.least_interval(["A", "A", "A", "B", "B", "B"], 0) == 6

    def test_single_task(self):
        assert self.sol.least_interval(["A"], 2) == 1

    def test_all_same(self):
        assert self.sol.least_interval(["A", "A", "A", "A"], 2) == 10

    def test_many_different(self):
        assert self.sol.least_interval(["A", "B", "C", "D", "E"], 2) == 5
