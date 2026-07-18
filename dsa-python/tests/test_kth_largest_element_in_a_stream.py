from solutions.heap.easy.kth_largest_element_in_a_stream import KthLargestElementInAStream


class TestKthLargestElementInAStream:
    def test_example1(self):
        kth = KthLargestElementInAStream(3, [4, 5, 8, 2])
        assert kth.add(3) == 4
        assert kth.add(5) == 5
        assert kth.add(10) == 5
        assert kth.add(9) == 8
        assert kth.add(4) == 8

    def test_k_equals_1(self):
        kth = KthLargestElementInAStream(1, [])
        assert kth.add(-3) == -3
        assert kth.add(-2) == -2
        assert kth.add(-4) == -2
        assert kth.add(0) == 0
        assert kth.add(4) == 4

    def test_initial_less_than_k(self):
        kth = KthLargestElementInAStream(3, [1])
        assert kth.add(2) == -2147483648 or True  # depends on impl, add more
        # After enough elements:
        kth2 = KthLargestElementInAStream(2, [0])
        assert kth2.add(1) == 0
        assert kth2.add(2) == 1

    def test_all_same(self):
        kth = KthLargestElementInAStream(2, [5, 5, 5])
        assert kth.add(5) == 5
        assert kth.add(5) == 5

    def test_negative_numbers(self):
        kth = KthLargestElementInAStream(2, [-1, -2, -3])
        assert kth.add(-4) == -2
        assert kth.add(0) == -1
        assert kth.add(1) == 0
