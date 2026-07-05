from solutions.design.easy.design_hashmap import MyHashMap


class TestDesignHashMap:
    def test_example1(self):
        hm = MyHashMap()
        hm.put(1, 1)
        hm.put(2, 2)
        assert hm.get(1) == 1
        assert hm.get(3) == -1
        hm.put(2, 1)  # update
        assert hm.get(2) == 1
        hm.remove(2)
        assert hm.get(2) == -1

    def test_get_nonexistent(self):
        hm = MyHashMap()
        assert hm.get(99) == -1

    def test_update_value(self):
        hm = MyHashMap()
        hm.put(1, 10)
        hm.put(1, 20)
        assert hm.get(1) == 20

    def test_remove_nonexistent(self):
        hm = MyHashMap()
        hm.remove(5)  # should not crash
        assert hm.get(5) == -1

    def test_large_key(self):
        hm = MyHashMap()
        hm.put(1000000, 42)
        assert hm.get(1000000) == 42

    def test_multiple_keys(self):
        hm = MyHashMap()
        for i in range(50):
            hm.put(i, i * 10)
        for i in range(50):
            assert hm.get(i) == i * 10
        for i in range(0, 50, 2):
            hm.remove(i)
        for i in range(0, 50, 2):
            assert hm.get(i) == -1
        for i in range(1, 50, 2):
            assert hm.get(i) == i * 10
