public class Solution {
    public int FirstCompleteIndex(int[] arr, int[][] mat) {
        int m = mat.Length, n = mat[0].Length;
        Dictionary<int, (int, int)> map = new();
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                map[mat[i][j]] = (i, j);
            }
        }

        var paintedRows = new int[m];
        var paintedCols = new int[n];

        for (int i = 0; i < arr.Length; i++) {
            var (row, col) = map[arr[i]];
            paintedRows[row]++;
            paintedCols[col]++;
            if (paintedRows[row] == n || paintedCols[col] == m) {
                return i;
            }
        }

        return 0;
    }
}