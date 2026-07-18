from solutions.array_and_hashing.medium.encode_and_decode_strings import EncodeAndDecodeStrings


class TestEncodeAndDecodeStrings:
    def setup_method(self):
        self.sol = EncodeAndDecodeStrings()

    def test_example1(self):
        # ["Hello","World"]
        strs = ["Hello", "World"]
        assert self.sol.decode(self.sol.encode(strs)) == strs

    def test_example2(self):
        # [""]
        strs = [""]
        assert self.sol.decode(self.sol.encode(strs)) == strs

    def test_empty_list(self):
        strs = []
        assert self.sol.decode(self.sol.encode(strs)) == strs

    def test_strings_with_special_chars(self):
        strs = ["we", "say", ":", "yes"]
        assert self.sol.decode(self.sol.encode(strs)) == strs

    def test_strings_with_numbers(self):
        strs = ["123", "456", "789"]
        assert self.sol.decode(self.sol.encode(strs)) == strs

    def test_multiple_empty_strings(self):
        strs = ["", "", ""]
        assert self.sol.decode(self.sol.encode(strs)) == strs

    def test_strings_with_delimiter_chars(self):
        strs = ["a#b", "c#d", "#"]
        assert self.sol.decode(self.sol.encode(strs)) == strs

    def test_single_string(self):
        strs = ["onlyone"]
        assert self.sol.decode(self.sol.encode(strs)) == strs
