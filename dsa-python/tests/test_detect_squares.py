from solutions.math_and_geometry.medium.detect_squares import DetectSquares


class TestDetectSquares:
    def setup_method(self):
        self.ds = DetectSquares()

    def test_example(self):
        self.ds.add([3, 10])
        self.ds.add([11, 1])
        self.ds.add([3, 1])
        assert self.ds.count([11, 10]) == 1
        assert self.ds.count([14, 8]) == 0
        self.ds.add([11, 10])
        assert self.ds.count([11, 10]) == 1

    def test_no_points(self):
        assert self.ds.count([0, 0]) == 0

    def test_duplicate_points(self):
        self.ds.add([0, 0])
        self.ds.add([0, 1])
        self.ds.add([1, 0])
        self.ds.add([1, 1])
        self.ds.add([1, 1])
        assert self.ds.count([0, 0]) == 2

    def test_multiple_squares(self):
        ds = DetectSquares()
        ds.add([0, 0])
        ds.add([0, 2])
        ds.add([2, 0])
        ds.add([2, 2])
        ds.add([0, 1])
        ds.add([1, 0])
        ds.add([1, 1])
        # Query [1, 1] can form squares with multiple sets of points
        assert ds.count([1, 1]) >= 1
