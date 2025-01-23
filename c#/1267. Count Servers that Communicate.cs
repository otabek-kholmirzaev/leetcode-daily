public class Solution {
    public int CountServers(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;

        Dictionary<int, int> row_dict = new();
        Dictionary<int, int> col_dict = new();
        
        int N = 0;
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i][j] == 1) {
                    if (!row_dict.ContainsKey(i)) row_dict[i] = 1; else row_dict[i]++;
                    if (!col_dict.ContainsKey(j)) col_dict[j] = 1; else col_dict[j]++;
                    N++;
                }
            }
        }

        int count = 0;
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i][j] == 1 && row_dict[i] == 1 && col_dict[j] == 1) 
                    count++;
            }
        }
        
        return N - count;
    }
}