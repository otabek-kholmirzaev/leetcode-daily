public class Solution {
    public int FindMaxFish(int[][] grid) {
        int ans = 0;
        var dx = new int[] { 0, 0, 1, -1 };
        var dy = new int[] { 1, -1, 0, 0 };
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[0].Length; j++) {
                if (grid[i][j] > 0) {
                    Queue<(int x, int y)> queue = new();
                    queue.Enqueue((i, j));
                    int count = grid[i][j];
                    grid[i][j] = 0;
                    while (queue.Count > 0) {
                        var (x, y) = queue.Dequeue();
                        for (int k = 0; k < 4; k++) {
                            int nx = x + dx[k], ny = y + dy[k];
                            if (nx < 0 || nx >= grid.Length || 
                                ny < 0 || ny >= grid[0].Length || 
                                grid[nx][ny] == 0) {
                                continue;
                            }

                            count += grid[nx][ny];
                            grid[nx][ny] = 0;
                            queue.Enqueue((nx, ny));
                        }
                    }

                    ans = Math.Max(ans, count);
                }
            }
        }

        return ans;
    }
}