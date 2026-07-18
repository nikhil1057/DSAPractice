from solutions.array_and_hashing.medium.group_anagrams import GroupAnagrams


class TestGroupAnagrams:
    def setup_method(self):
        self.sol = GroupAnagrams()

    def _sort_result(self, result):
        """Sort each group and the list of groups for comparison."""
        return sorted([sorted(group) for group in result])

    def test_example1(self):
        # ["eat","tea","tan","ate","nat","bat"]
        result = self.sol.group_anagrams(["eat", "tea", "tan", "ate", "nat", "bat"])
        expected = [["ate", "eat", "tea"], ["nat", "tan"], ["bat"]]
        assert self._sort_result(result) == self._sort_result(expected)

    def test_example2(self):
        # [""] => [[""]]
        result = self.sol.group_anagrams([""])
        assert result == [[""]]

    def test_example3(self):
        # ["a"] => [["a"]]
        result = self.sol.group_anagrams(["a"])
        assert result == [["a"]]

    def test_no_anagrams(self):
        result = self.sol.group_anagrams(["abc", "def", "ghi"])
        expected = [["abc"], ["def"], ["ghi"]]
        assert self._sort_result(result) == self._sort_result(expected)

    def test_all_anagrams(self):
        result = self.sol.group_anagrams(["abc", "bca", "cab"])
        expected = [["abc", "bca", "cab"]]
        assert self._sort_result(result) == self._sort_result(expected)

    def test_empty_list(self):
        result = self.sol.group_anagrams([])
        assert result == []

    def test_duplicate_strings(self):
        result = self.sol.group_anagrams(["a", "a"])
        expected = [["a", "a"]]
        assert self._sort_result(result) == self._sort_result(expected)
