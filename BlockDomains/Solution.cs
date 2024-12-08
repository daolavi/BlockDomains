namespace BlockDomains;

public static class Solution
{
    public static int[] Check(string[] a, string[] b)
    {
        var trie = BuildTrieForBlockedDomains(b);
        var result = new List<int>();
        for (var i = 0; i < a.Length; i++)
        {
            if (IsDomainAccessible(a[i], trie))
            {
                result.Add(i);
            }
        }

        return result.ToArray();
    }

    private static TrieNode BuildTrieForBlockedDomains(string[] blockedDomains)
    {
        var root = new TrieNode();
        foreach (var domain in blockedDomains)
        {
            var tokens = domain.Split('.');
            var node = root;
            for (var i = tokens.Length - 1; i >= 0; i--)
            {
                var token = tokens[i];
                if (!node.Children.ContainsKey(token))
                {
                    node.Children[token] = new TrieNode();
                }
                node = node.Children[token];
            }

            node.Blocked = true;
        }

        return root;
    }

    private static bool IsDomainAccessible(string domain, TrieNode root)
    {
        var tokens = domain.Split('.');
        var node = root;
        for (var i = tokens.Length - 1; i >= 0; i--)
        {
            var token = tokens[i];
            if (node.Children.ContainsKey(token))
            {
                node = node.Children[token];
                if (node.Blocked)
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
        return true;
    }
}

public class TrieNode()
{
    public Dictionary<string, TrieNode> Children { get; set; } = new();
    public bool Blocked;
}