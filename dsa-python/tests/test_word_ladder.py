from solutions.graphs.hard.word_ladder import WordLadder


class TestWordLadder:
    def setup_method(self):
        self.sol = WordLadder()

    def test_example1(self):
        assert self.sol.ladder_length("hit", "cog", ["hot", "dot", "dog", "lot", "log", "cog"]) == 5

    def test_example2(self):
        assert self.sol.ladder_length("hit", "cog", ["hot", "dot", "dog", "lot", "log"]) == 0

    def test_one_step(self):
        assert self.sol.ladder_length("hot", "dot", ["dot"]) == 2

    def test_no_path(self):
        assert self.sol.ladder_length("abc", "xyz", ["abd", "xyd"]) == 0

    def test_end_not_in_list(self):
        assert self.sol.ladder_length("hit", "cog", ["hot", "dot", "dog"]) == 0

    def test_direct_neighbor(self):
        assert self.sol.ladder_length("a", "c", ["a", "b", "c"]) == 2

    def test_longer_path(self):
        word_list = ["hot", "dot", "dog", "lot", "log", "cog"]
        # hit -> hot -> dot -> dog -> cog = 5
        assert self.sol.ladder_length("hit", "cog", word_list) == 5

    def test_same_length_words(self):
        assert self.sol.ladder_length("ab", "cd", ["ab", "ad", "cd"]) == 3
