// WATCH SOLUTION BY NEETCODE -> https://youtu.be/wciKkM3g3wQ

public class Solution {
    public IList<int> EventualSafeNodes(int[][] graph) {
        var n = graph.Length;
        var isSafe = new Dictionary<int, bool>();
        var ans = new List<int>();
        for (int i = 0; i < graph.Length; i++) {
            if (Dfs(i)) ans.Add(i);
        }

        return ans;

        bool Dfs(int i) {
            if (isSafe.ContainsKey(i)) return isSafe[i];
            
            isSafe[i] = false;
            foreach (var nei in graph[i]) {
                if (!Dfs(nei)) return isSafe[i];
            }

            isSafe[i] = true;
            return isSafe[i];
        }
    }
}