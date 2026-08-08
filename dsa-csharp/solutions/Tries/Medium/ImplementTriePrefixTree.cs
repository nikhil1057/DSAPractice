// 208. Implement Trie (Prefix Tree)
// https://leetcode.com/problems/implement-trie-prefix-tree/
//
// A trie (pronounced as "try") or prefix tree is a tree data structure used to
// efficiently store and retrieve keys in a dataset of strings.
// Implement the Trie class:
// - Trie() Initializes the trie object.
// - void insert(String word) Inserts the string word into the trie.
// - boolean search(String word) Returns true if the string word is in the trie.
// - boolean startsWith(String prefix) Returns true if there is a previously
//   inserted string word that has the prefix prefix.
//
// Example 1:
//   Input: ["Trie", "insert", "search", "search", "startsWith", "insert", "search"]
//          [[], ["apple"], ["apple"], ["app"], ["app"], ["app"], ["app"]]
//   Output: [null, null, true, false, true, null, true]
//
// Constraints:
// - 1 <= word.length, prefix.length <= 2000
// - word and prefix consist only of lowercase English letters.

// APPROACH: Trie (Prefix Tree) using dictionary-based nodes
// Each node stores a dict of children (char → TrieNode) and an IsEnd flag.
// Insert walks/creates the path. Search/StartsWith reuse a Walk helper;
// Search checks IsEnd, StartsWith just checks the path exists.
//
// TIME: O(m) for all operations, where m = length of word/prefix
// SPACE: O(N * M) total, where N = number of words, M = avg length
//        Shared prefixes reduce actual space usage.

public class ImplementTriePrefixTree
{
    private TrieNode root;

    public ImplementTriePrefixTree()
    {
        root = new();  // Root represents empty prefix ""
    }

    public void Insert(string word)
    {
        var node = root;
        foreach(char c in word)
        {
            // Create child node if this character path doesn't exist
            if(!node.Children.ContainsKey(c))
            {
                node.Children[c] = new TrieNode();
            }

            node = node.Children[c];  // Move down to child
        }
        node.IsEnd = true;  // Mark end of word
    }

    public bool Search(string word)
    {
        var node = Walk(word);
        // Must reach end of path AND be a complete word
        return node != null && node.IsEnd;
    }

    public bool StartsWith(string prefix)
    {
        // Just need the path to exist — don't care about IsEnd
        return Walk(prefix) != null;
    }

    /// Walk the trie following string s. Return end node or null if path breaks.
    private TrieNode? Walk(string s)
    {
        var node = root;
        foreach(char c in s)
        {
            if(!node.Children.ContainsKey(c))  // Path doesn't exist
            {
                return null;
            }
            node = node.Children[c];
        }

        return node;
    }
}

public class TrieNode
{
    public Dictionary<char,TrieNode> Children = new();  // char → child node
    public bool IsEnd = false;  // True if a complete word ends here
}
