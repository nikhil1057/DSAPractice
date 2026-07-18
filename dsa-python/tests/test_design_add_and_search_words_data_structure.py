from solutions.tries.medium.design_add_and_search_words_data_structure import DesignAddAndSearchWordsDataStructure


class TestDesignAddAndSearchWordsDataStructure:
    def setup_method(self):
        self.wd = DesignAddAndSearchWordsDataStructure()

    def test_example1(self):
        self.wd.add_word("bad")
        self.wd.add_word("dad")
        self.wd.add_word("mad")
        assert self.wd.search("pad") is False
        assert self.wd.search("bad") is True
        assert self.wd.search(".ad") is True
        assert self.wd.search("b..") is True

    def test_dot_at_beginning(self):
        self.wd.add_word("hello")
        assert self.wd.search(".ello") is True
        assert self.wd.search("..llo") is True

    def test_all_dots(self):
        self.wd.add_word("abc")
        assert self.wd.search("...") is True
        assert self.wd.search("....") is False

    def test_no_match(self):
        self.wd.add_word("cat")
        assert self.wd.search("dog") is False
        assert self.wd.search("ca") is False

    def test_empty_dictionary(self):
        assert self.wd.search("a") is False
        assert self.wd.search(".") is False

    def test_single_char_words(self):
        self.wd.add_word("a")
        self.wd.add_word("b")
        assert self.wd.search(".") is True
        assert self.wd.search("a") is True
        assert self.wd.search("c") is False

    def test_dot_at_end(self):
        self.wd.add_word("test")
        assert self.wd.search("tes.") is True
        assert self.wd.search("te..") is True
        assert self.wd.search("t...") is True
