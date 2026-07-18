from solutions.linked_list.medium.lru_cache import LRUCache


class TestLRUCache:
    def test_example1(self):
        cache = LRUCache(2)
        cache.put(1, 1)
        cache.put(2, 2)
        assert cache.get(1) == 1
        cache.put(3, 3)  # evicts key 2
        assert cache.get(2) == -1
        cache.put(4, 4)  # evicts key 1
        assert cache.get(1) == -1
        assert cache.get(3) == 3
        assert cache.get(4) == 4

    def test_get_nonexistent(self):
        cache = LRUCache(2)
        assert cache.get(1) == -1

    def test_update_existing_key(self):
        cache = LRUCache(2)
        cache.put(1, 1)
        cache.put(1, 10)
        assert cache.get(1) == 10

    def test_capacity_one(self):
        cache = LRUCache(1)
        cache.put(1, 1)
        cache.put(2, 2)
        assert cache.get(1) == -1
        assert cache.get(2) == 2

    def test_get_refreshes_usage(self):
        cache = LRUCache(2)
        cache.put(1, 1)
        cache.put(2, 2)
        cache.get(1)  # refreshes key 1
        cache.put(3, 3)  # should evict key 2 (LRU)
        assert cache.get(2) == -1
        assert cache.get(1) == 1

    def test_put_refreshes_usage(self):
        cache = LRUCache(2)
        cache.put(1, 1)
        cache.put(2, 2)
        cache.put(1, 10)  # refreshes key 1
        cache.put(3, 3)  # should evict key 2 (LRU)
        assert cache.get(2) == -1
        assert cache.get(1) == 10

    def test_larger_capacity(self):
        cache = LRUCache(3)
        cache.put(1, 1)
        cache.put(2, 2)
        cache.put(3, 3)
        cache.put(4, 4)  # evicts key 1
        assert cache.get(1) == -1
        assert cache.get(2) == 2
        assert cache.get(3) == 3
        assert cache.get(4) == 4
