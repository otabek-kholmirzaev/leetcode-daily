public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {
        var uf = new UnionFind(1001);
        foreach (var edge in edges) {
            if (!uf.Union(edge[0], edge[1])) return edge;
        }

        return new int[0];
    }
}

public class UnionFind {
    int[] parent;

    public UnionFind(int n) {
        parent = new int[n];
        for (int i = 0; i < n; i++) parent[i] = i;
    }

    private int Find(int x) {
        int y = x;
        while (y != parent[y]) y = parent[y];
        parent[x] = y;
        return y;
    }

    public bool Union(int x, int y) {
        int X = Find(x);
        int Y = Find(y);
        if (X == Y) return false;
        parent[X] = Y;
        return true;
    }
}