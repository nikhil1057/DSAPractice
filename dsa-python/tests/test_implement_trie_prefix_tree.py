from solutions.tries.medium.implement_trie_prefix_tree import ImplementTriePrefixTree


class TestImplementTriePrefixTree:
    def setup_method(self):
        self.trie = ImplementTriePrefixTree()

    def test_example1(self):
        self.trie.insert("apple")
        assert self.trie.search("apple") is True
        assert self.trie.search("app") is False
        assert self.trie.starts_with("app") is True
        self.trie.insert("app")
        assert self.trie.search("app") is True

    def test_search_nonexistent(self):
        self.trie.insert("hello")
        assert self.trie.search("hell") is False
        assert self.trie.search("helloo") is False

    def test_starts_with(self):
        self.trie.insert("prefix")
        assert self.trie.starts_with("pre") is True
        assert self.trie.starts_with("prefix") is True
        assert self.trie.starts_with("prefixx") is False

    def test_empty_trie(self):
        assert self.trie.search("anything") is False
        assert self.trie.starts_with("a") is False

    def test_single_character(self):
        self.trie.insert("a")
        assert self.trie.search("a") is True
        assert self.trie.starts_with("a") is True
        assert self.trie.search("b") is False

    def test_multiple_words_same_prefix(self):
        self.trie.insert("car")
        self.trie.insert("card")
        self.trie.insert("care")
        assert self.trie.search("car") is True
        assert self.trie.search("card") is True
        assert self.trie.search("care") is True
        assert self.trie.search("cars") is False

    def test_insert_duplicate(self):
        self.trie.insert("test")
        self.trie.insert("test")
        assert self.trie.search("test") is True
