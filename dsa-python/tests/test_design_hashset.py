from solutions.design_hashset import MyHashSet


class TestDesignHashSet:
    def test_example1(self):
        hs = MyHashSet()
        hs.add(1)
        hs.add(2)
        assert hs.contains(1) is True
        assert hs.contains(3) is False
        hs.add(2)
        assert hs.contains(2) is True
        hs.remove(2)
        assert hs.contains(2) is False

    def test_add_and_contains(self):
        hs = MyHashSet()
        hs.add(5)
        assert hs.contains(5) is True
        assert hs.contains(6) is False

    def test_remove_nonexistent(self):
        hs = MyHashSet()
        hs.remove(10)  # should not crash
        assert hs.contains(10) is False

    def test_add_duplicate(self):
        hs = MyHashSet()
        hs.add(1)
        hs.add(1)
        hs.remove(1)
        assert hs.contains(1) is False

    def test_large_key(self):
        hs = MyHashSet()
        hs.add(1000000)
        assert hs.contains(1000000) is True
        hs.remove(1000000)
        assert hs.contains(1000000) is False

    def test_multiple_operations(self):
        hs = MyHashSet()
        for i in range(100):
            hs.add(i)
        for i in range(100):
            assert hs.contains(i) is True
        for i in range(0, 100, 2):
            hs.remove(i)
        for i in range(0, 100, 2):
            assert hs.contains(i) is False
        for i in range(1, 100, 2):
            assert hs.contains(i) is True
