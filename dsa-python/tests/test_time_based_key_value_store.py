from solutions.binary_search.medium.time_based_key_value_store import TimeBasedKeyValueStore


class TestTimeBasedKeyValueStore:
    def setup_method(self):
        self.tm = TimeBasedKeyValueStore()

    def test_example1(self):
        self.tm.set("foo", "bar", 1)
        assert self.tm.get("foo", 1) == "bar"
        assert self.tm.get("foo", 3) == "bar"
        self.tm.set("foo", "bar2", 4)
        assert self.tm.get("foo", 4) == "bar2"
        assert self.tm.get("foo", 5) == "bar2"

    def test_get_before_any_set(self):
        self.tm.set("key", "val", 5)
        assert self.tm.get("key", 3) == ""

    def test_nonexistent_key(self):
        assert self.tm.get("missing", 1) == ""

    def test_exact_timestamp(self):
        self.tm.set("a", "v1", 1)
        self.tm.set("a", "v2", 2)
        self.tm.set("a", "v3", 3)
        assert self.tm.get("a", 2) == "v2"

    def test_between_timestamps(self):
        self.tm.set("a", "v1", 1)
        self.tm.set("a", "v2", 5)
        assert self.tm.get("a", 3) == "v1"

    def test_multiple_keys(self):
        self.tm.set("x", "val_x", 1)
        self.tm.set("y", "val_y", 1)
        assert self.tm.get("x", 1) == "val_x"
        assert self.tm.get("y", 1) == "val_y"

    def test_large_timestamp_gap(self):
        self.tm.set("k", "first", 1)
        self.tm.set("k", "second", 1000)
        assert self.tm.get("k", 500) == "first"
        assert self.tm.get("k", 1000) == "second"
