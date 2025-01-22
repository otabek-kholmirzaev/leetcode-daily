// https://leetcode.com/problems/map-of-highest-peak/

public class Solution {
    public int[][] HighestPeak(int[][] isWater) {
        int m = isWater.Length, n = isWater[0].Length;
        var visited = new bool[m, n];
        var res = new int[m][];
        int[][] dirs = [[1, 0], [-1, 0], [0, 1], [0, -1]]; 
        Queue<(int row, int col)> queue = new();
        for (int i = 0; i < m; i++) {
            res[i] = new int[n];
            for (int j = 0; j < n; j++) {
                if (isWater[i][j] == 1) {
                    queue.Enqueue((i, j));
                    visited[i, j] = true;    
                    res[i][j] = 0;
                }
            }
        }

        int level = 0;
        while (queue.Count > 0) {
            level++;

            int count = queue.Count;
            for (int i = 0; i < count; i++) {
                var (row, col) = queue.Dequeue();
                foreach (var dir in dirs) {
                    var (newRow, newCol) = (row + dir[0], col + dir[1]);
                    if (newRow < 0 || newRow >= m || newCol < 0 || newCol >= n) continue; // not valid
                    if (!visited[newRow, newCol] && isWater[newRow][newCol] == 0) {
                        res[newRow][newCol] = level;
                        visited[newRow, newCol] = true;
                        queue.Enqueue((newRow, newCol));
                    }
                }
            }
        }

        return res;
    }
}