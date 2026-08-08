# 211. Design Add and Search Words Data Structure
# https://leetcode.com/problems/design-add-and-search-words-data-structure/
#
# Design a data structure that supports adding new words and finding if a string
# matches any previously added string.
# Implement the WordDictionary class:
# - WordDictionary() Initializes the object.
# - void addWord(word) Adds word to the data structure.
# - bool search(word) Returns true if there is any string in the data structure
#   that matches word. word may contain dots '.' where dots can match any letter.
#
# Example 1:
#   Input: ["WordDictionary","addWord","addWord","addWord","search","search","search","search"]
#          [[],["bad"],["dad"],["mad"],["pad"],["bad"],[".ad"],["b.."]]
#   Output: [null,null,null,null,false,true,true,true]
#
# Constraints:
# - 1 <= word.length <= 25
# - word in addWord consists of lowercase English letters.
# - word in search consist of '.' or lowercase English letters.
# - At most 10^4 calls will be made to addWord and search.


# APPROACH: Trie + DFS for wildcard '.' matching
# addWord: standard Trie insert — walk/create path, mark is_end
# search: DFS — for normal chars, follow the path. For '.', branch into ALL
# children and return True if any branch succeeds.
#
# TIME: addWord O(m), search O(m) normal, O(26^m) worst case (all dots)
# SPACE: O(N * M) for the trie

class TrieNode:
    def __init__(self):
        self.children = {}   # char → TrieNode
        self.is_end = False  # True if a complete word ends here

class DesignAddAndSearchWordsDataStructure:
    def __init__(self):
        self.root = TrieNode()

    def add_word(self, word: str) -> None:
        """Standard Trie insert — identical to Implement Trie."""
        node = self.root
        for char in word:
            if char not in node.children:
                node.children[char] = TrieNode()  # create new node
            node = node.children[char]
        node.is_end = True  # mark word boundary

    def search(self, word: str) -> bool:
        """Search with '.' wildcard support using DFS."""
        def dfs(node, index):
            # Base case: processed all characters — check if word ends here
            if index == len(word):
                return node.is_end

            char = word[index]

            if char == '.':
                # Wildcard: try every child, return True if ANY matches
                for child in node.children.values():
                    if dfs(child, index + 1):
                        return True
                return False  # no child matched
            else:
                # Normal char: follow the path or fail
                if char not in node.children:
                    return False
                return dfs(node.children[char], index + 1)

        return dfs(self.root, 0)

