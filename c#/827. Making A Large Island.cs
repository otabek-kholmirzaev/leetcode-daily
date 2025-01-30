public class Solution {
    public int LargestIsland(int[][] grid) {
        int n = grid.Length;
        var uf = new UnionFind(n * n);
        var dx = new int[] { 0, 0, 1, -1 };
        var dy = new int[] { 1, -1, 0, 0 };
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i][j] != 1) continue;
                int index = i * n + j;
                for (int k = 0; k < 4; k++) {
                    int nx = i + dx[k], ny = j + dy[k];
                    if (!IsValid(nx, ny, n) || grid[nx][ny] != 1) continue;
                    int nei_index = nx * n + ny;
                    uf.Union(index, nei_index);
                }
            }
        }

        int max = 0;
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i][j] == 1) {
                    int index = i * n + j;
                    max = Math.Max(max, uf.GetComponentCount(index));
                    continue;
                }

                HashSet<int> parents = new();
                for (int k = 0; k < 4; k++) {
                    int nx = i + dx[k], ny = j + dy[k];
                    if(!IsValid(nx, ny, n) || grid[nx][ny] != 1) continue;
                    int nei_index = nx * n + ny;
                    int nei_root = uf.Find(nei_index);
                    parents.Add(nei_root);
                }

                int count = 1;
                foreach (var parent in parents) {
                    count += uf.GetComponentCount(parent);
                }

                max = Math.Max(max, count);
            }
        }

        return max;
    }

    bool IsValid(int x, int y, int n) {
        return x >= 0 && x < n && y >= 0 && y < n;
    }
}

public class UnionFind {
    int[] parent;
    int[] rank;

    public UnionFind(int n) {
        parent = new int[n];
        rank = new int[n];

        for (int i = 0; i < n; i++) {
            parent[i] = i;
            rank[i] = 1;
        }
    }

    public int Find(int x) {
        int y = x;
        while (x != parent[x]) x = parent[x];
        parent[y] = x;
        return x;
    }

    public bool Union(int x, int y) {
        int rootX = Find(x), rootY = Find(y);
        if (rootX == rootY) return false;
        
        if (rank[rootX] < rank[rootY]) {
            parent[rootX] = rootY;
            rank[rootY] += rank[rootX];
        }
        else {
            parent[rootY] = rootX;
            rank[rootX] += rank[rootY];
        }

        return true;
    }

    public int GetComponentCount(int x) {
        int rootX = Find(x);
        return rank[rootX]; 
    }
}