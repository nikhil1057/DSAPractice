// 211. Design Add and Search Words Data Structure
// https://leetcode.com/problems/design-add-and-search-words-data-structure/
//
// Design a data structure that supports adding new words and finding if a string
// matches any previously added string.
// Implement the WordDictionary class:
// - WordDictionary() Initializes the object.
// - void addWord(word) Adds word to the data structure.
// - bool search(word) Returns true if there is any string that matches word.
//   word may contain dots '.' where dots can match any letter.
//
// Example 1:
//   Input: ["WordDictionary","addWord","addWord","addWord","search","search","search","search"]
//          [[],["bad"],["dad"],["mad"],["pad"],["bad"],[".ad"],["b.."]]
//   Output: [null,null,null,null,false,true,true,true]
//
// Constraints:
// - 1 <= word.length <= 25
// - word in addWord consists of lowercase English letters.
// - word in search consist of '.' or lowercase English letters.

// APPROACH: Trie + DFS for wildcard '.' matching
// AddWord: standard Trie insert — walk/create path, mark IsEnd
// Search: DFS — for normal chars, follow the path. For '.', branch into ALL
// children and return true if any branch succeeds.
//
// TIME: AddWord O(m), Search O(m) normal, O(26^m) worst case (all dots)
// SPACE: O(N * M) for the trie

public class DesignAddAndSearchWordsDataStructure
{
    private TrieNode root;

    public DesignAddAndSearchWordsDataStructure()
    {
        root = new TrieNode();
    }

    /// Standard Trie insert — identical to Implement Trie.
    public void AddWord(string word)
    {
        var node = root;
        foreach (char c in word)
        {
            if (!node.Children.ContainsKey(c))
                node.Children[c] = new TrieNode();  // create new node
            node = node.Children[c];  // move down
        }
        node.IsEnd = true;  // mark word boundary
    }

    /// Search with '.' wildcard support — delegates to DFS.
    public bool Search(string word)
    {
        return DFS(root, 0, word);
    }

    private bool DFS(TrieNode node, int index, string word)
    {
        // Base case: processed all characters — check if word ends here
        if (index == word.Length) return node.IsEnd;

        char c = word[index];

        if (c == '.')
        {
            // Wildcard: try every child, return true if ANY matches
            foreach (TrieNode child in node.Children.Values)
            {
                if (DFS(child, index + 1, word)) return true;
            }
            return false;  // no child matched
        }
        else
        {
            // Normal char: follow the path or fail
            if (!node.Children.ContainsKey(c)) return false;
            return DFS(node.Children[c], index + 1, word);  // advance to child node
        }
    }
}
