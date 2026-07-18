from solutions.heap.hard.find_median_from_data_stream import FindMedianFromDataStream


class TestFindMedianFromDataStream:
    def test_example1(self):
        mf = FindMedianFromDataStream()
        mf.add_num(1)
        mf.add_num(2)
        assert mf.find_median() == 1.5
        mf.add_num(3)
        assert mf.find_median() == 2.0

    def test_single_element(self):
        mf = FindMedianFromDataStream()
        mf.add_num(5)
        assert mf.find_median() == 5.0

    def test_two_elements(self):
        mf = FindMedianFromDataStream()
        mf.add_num(1)
        mf.add_num(2)
        assert mf.find_median() == 1.5

    def test_odd_count(self):
        mf = FindMedianFromDataStream()
        for num in [1, 2, 3, 4, 5]:
            mf.add_num(num)
        assert mf.find_median() == 3.0

    def test_even_count(self):
        mf = FindMedianFromDataStream()
        for num in [1, 2, 3, 4]:
            mf.add_num(num)
        assert mf.find_median() == 2.5

    def test_negative_numbers(self):
        mf = FindMedianFromDataStream()
        mf.add_num(-1)
        mf.add_num(-2)
        mf.add_num(-3)
        assert mf.find_median() == -2.0

    def test_duplicates(self):
        mf = FindMedianFromDataStream()
        mf.add_num(1)
        mf.add_num(1)
        mf.add_num(1)
        assert mf.find_median() == 1.0

    def test_unsorted_input(self):
        mf = FindMedianFromDataStream()
        mf.add_num(6)
        assert mf.find_median() == 6.0
        mf.add_num(10)
        assert mf.find_median() == 8.0
        mf.add_num(2)
        assert mf.find_median() == 6.0
