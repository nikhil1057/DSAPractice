# 212. Word Search II
# https://leetcode.com/problems/word-search-ii/
#
# Given an m x n board of characters and a list of strings words, return all
# words on the board. Each word must be constructed from letters of sequentially
# adjacent cells, where adjacent cells are horizontally or vertically neighboring.
# The same letter cell may not be used more than once in a word.
#
# Example 1:
#   Input: board = [["o","a","a","n"],["e","t","a","e"],["i","h","k","r"],["i","f","l","v"]],
#          words = ["oath","pea","eat","rain"]
#   Output: ["eat","oath"]
# Example 2:
#   Input: board = [["a","b"],["c","d"]], words = ["abcb"]
#   Output: []
#
# Constraints:
# - m == board.length, n == board[i].length
# - 1 <= m, n <= 12
# - board[i][j] is a lowercase English letter.
# - 1 <= words.length <= 3 * 10^4
# - 1 <= words[i].length <= 10
# - words[i] consists of lowercase English letters.
# - All the strings of words are unique.

# APPROACH: Trie + Backtracking (DFS on board with Trie as guide)
# 1. Build Trie from all words (store full word at end node)
# 2. For each cell, start DFS that walks board AND Trie simultaneously
# 3. Prune: if Trie has no child for current char → stop
# 4. Found: if Trie node has a word → add to results
# 5. Optimize: remove found words and prune dead branches
#
# TIME: O(m * n * 4^L) worst case, but Trie pruning makes it much faster
# SPACE: O(total chars in all words) for Trie

class TrieNode:
    def __init__(self):
        self.children = {}   # char → TrieNode
        self.word = ""       # store full word at end node ("" = no word here)

class WordSearchII:
    def _build_trie(self, words: list[str]) -> TrieNode:
        root = TrieNode()
        for word in words:
            node = root
            for char in word:
                if char not in node.children:
                    node.children[char] = TrieNode()
                node = node.children[char]
            node.word = word  # store word at the end node
        return root

    def find_words(self, board: list[list[str]], words: list[str]) -> list[str]:
        result = []
        root = self._build_trie(words)

        def dfs(node: TrieNode, r: int, c: int):
            # Boundary check
            if r < 0 or r >= len(board) or c < 0 or c >= len(board[0]):
                return

            ch = board[r][c]

            # Already visited or Trie has no path for this char
            if ch == '#' or ch not in node.children:
                return

            child = node.children[ch]

            # Found a word — add to results, mark as found
            if child.word != "":
                result.append(child.word)
                child.word = ""  # avoid duplicates

            # Mark visited
            board[r][c] = '#'

            # Explore 4 directions
            dfs(child, r + 1, c)
            dfs(child, r - 1, c)
            dfs(child, r, c + 1)
            dfs(child, r, c - 1)

            # Backtrack
            board[r][c] = ch

            # Prune dead branch — no words left down this path
            if len(child.children) == 0:
                del node.children[ch]

        # Try starting DFS from every cell
        for r in range(len(board)):
            for c in range(len(board[0])):
                if board[r][c] in root.children:
                    dfs(root, r, c)

        return result
