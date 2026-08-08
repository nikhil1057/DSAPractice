// 212. Word Search II
// https://leetcode.com/problems/word-search-ii/
//
// Given an m x n board of characters and a list of strings words, return all
// words on the board. Each word must be constructed from letters of sequentially
// adjacent cells, where adjacent cells are horizontally or vertically neighboring.
// The same letter cell may not be used more than once in a word.
//
// Example 1:
//   Input: board = [["o","a","a","n"],["e","t","a","e"],["i","h","k","r"],["i","f","l","v"]],
//          words = ["oath","pea","eat","rain"]
//   Output: ["eat","oath"]
// Example 2:
//   Input: board = [["a","b"],["c","d"]], words = ["abcb"]
//   Output: []
//
// Constraints:
// - m == board.length, n == board[i].length
// - 1 <= m, n <= 12
// - 1 <= words.length <= 3 * 10^4
// - 1 <= words[i].length <= 10


// APPROACH: Trie + Backtracking (DFS on board with Trie as guide)
// 1. Build Trie from all words (store full word at end node)
// 2. For each cell, start DFS that walks board AND Trie simultaneously
// 3. Prune: if Trie has no child for current char → stop
// 4. Found: if Trie node marks end of word → add to results
// 5. Optimize: remove found words and prune dead branches
//
// TIME: O(m * n * 4^L) worst case, but Trie pruning makes it much faster
// SPACE: O(total chars in all words) for Trie

public class WordSearchII
{
    private class TrieNode
    {
        public Dictionary<char, TrieNode> Children = new();
        public string? Word = null;  // store full word at end node
    }

    private TrieNode BuildTrie(string[] words)
    {
        TrieNode root = new TrieNode();

        foreach (string word in words)
        {
            TrieNode node = root;  // reset for each word
            foreach (char c in word)
            {
                if (!node.Children.ContainsKey(c))
                    node.Children[c] = new TrieNode();
                node = node.Children[c];
            }
            node.Word = word;  // store word at end node
        }

        return root;
    }

    private void FindWordDFS(char[][] board, List<string> result, TrieNode node, int r, int c)
    {
        // Boundary check
        if (r < 0 || r >= board.Length || c < 0 || c >= board[0].Length) return;

        char ch = board[r][c];

        // Already visited or Trie has no path for this char
        if (ch == '#' || !node.Children.ContainsKey(ch)) return;

        TrieNode child = node.Children[ch];

        // Found a word — add to results, mark as found
        if (child.Word != null)
        {
            result.Add(child.Word);
            child.Word = null;  // avoid duplicates
        }

        // Mark visited
        board[r][c] = '#';

        // Explore 4 directions
        FindWordDFS(board, result, child, r + 1, c);
        FindWordDFS(board, result, child, r - 1, c);
        FindWordDFS(board, result, child, r, c + 1);
        FindWordDFS(board, result, child, r, c - 1);

        // Backtrack
        board[r][c] = ch;

        // Prune dead branch — no words left down this path
        if (child.Children.Count == 0)
        {
            node.Children.Remove(ch);
        }
    }

    public IList<string> FindWords(char[][] board, string[] words)
    {
        List<string> result = new();
        TrieNode root = BuildTrie(words);

        for (int r = 0; r < board.Length; r++)
        {
            for (int c = 0; c < board[0].Length; c++)
            {
                // Only start DFS if this char begins some word
                if (root.Children.ContainsKey(board[r][c]))
                {
                    FindWordDFS(board, result, root, r, c);
                }
            }
        }

        return result;
    }
}
