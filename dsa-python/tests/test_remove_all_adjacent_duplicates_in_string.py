from solutions.stack.easy.remove_all_adjacent_duplicates_in_string import RemoveAllAdjacentDuplicatesInString


class TestRemoveAllAdjacentDuplicatesInString:
    def setup_method(self):
        self.sol = RemoveAllAdjacentDuplicatesInString()

    def test_example1(self):
        # "abbaca" → "ca"
        assert self.sol.remove_duplicates("abbaca") == "ca"

    def test_example2(self):
        # "azxxzy" → "ay"
        assert self.sol.remove_duplicates("azxxzy") == "ay"

    def test_no_duplicates(self):
        # "abc" → "abc" (nothing to remove)
        assert self.sol.remove_duplicates("abc") == "abc"

    def test_all_duplicates(self):
        # "aabbcc" → "" (all cancel out)
        assert self.sol.remove_duplicates("aabbcc") == ""

    def test_single_char(self):
        assert self.sol.remove_duplicates("a") == "a"

    def test_cascading_removal(self):
        # "abccba" → "abba" → "aa" → ""
        assert self.sol.remove_duplicates("abccba") == ""

    def test_duplicate_at_start(self):
        # "aabc" → "bc"
        assert self.sol.remove_duplicates("aabc") == "bc"

    def test_duplicate_at_end(self):
        # "abcc" → "ab"
        assert self.sol.remove_duplicates("abcc") == "ab"
