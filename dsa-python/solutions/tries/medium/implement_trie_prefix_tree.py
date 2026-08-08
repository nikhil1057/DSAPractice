# 208. Implement Trie (Prefix Tree)
# https://leetcode.com/problems/implement-trie-prefix-tree/
#
# A trie (pronounced as "try") or prefix tree is a tree data structure used to
# efficiently store and retrieve keys in a dataset of strings.
# Implement the Trie class:
# - Trie() Initializes the trie object.
# - void insert(String word) Inserts the string word into the trie.
# - boolean search(String word) Returns true if the string word is in the trie.
# - boolean startsWith(String prefix) Returns true if there is a previously
#   inserted string word that has the prefix prefix.
#
# Example 1:
#   Input: ["Trie", "insert", "search", "search", "startsWith", "insert", "search"]
#          [[], ["apple"], ["apple"], ["app"], ["app"], ["app"], ["app"]]
#   Output: [null, null, true, false, true, null, true]
#
# Constraints:
# - 1 <= word.length, prefix.length <= 2000
# - word and prefix consist only of lowercase English letters.
# - At most 3 * 10^4 calls in total will be made to insert, search, and startsWith.

# APPROACH: Trie (Prefix Tree) using dictionary-based nodes
# Each node stores a dict of children (char → TrieNode) and an is_end flag.
# Insert walks/creates the path. Search/StartsWith reuse a _walk helper;
# search checks is_end, startsWith just checks the path exists.
#
# TIME: O(m) for all operations, where m = length of word/prefix
# SPACE: O(N * M) total, where N = number of words, M = avg length
#        Shared prefixes reduce actual space usage.

class TrieNode:
    def __init__(self):
        self.children = {}   # char → TrieNode
        self.is_end = False  # True if a complete word ends at this node

class ImplementTriePrefixTree:
    def __init__(self):
        self.root = TrieNode()  # root represents empty prefix ""

    def insert(self, word: str) -> None:
        node = self.root

        for char in word:
            # Create child node if this character path doesn't exist
            if char not in node.children:
                node.children[char] = TrieNode()
            node = node.children[char]  # Move down to child

        node.is_end = True  # Mark end of word

    def search(self, word: str) -> bool:
        node = self._walk(word)
        # Must reach end of path AND be a complete word
        return node is not None and node.is_end

    def starts_with(self, prefix: str) -> bool:
        # Just need the path to exist — don't care about is_end
        return self._walk(prefix) is not None

    def _walk(self, s: str):
        """Walk the trie following string s. Return end node or None if path breaks."""
        node = self.root
        for char in s:
            if char not in node.children:  # Path doesn't exist
                return None
            node = node.children[char]
        return node