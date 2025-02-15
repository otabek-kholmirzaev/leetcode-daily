public class Solution {
    public int PunishmentNumber(int n) {
        int count = 0;

        for (int i = 1; i <= n; i++) {
            count += Can(0, (i * i).ToString(), i, 0, 0) ? (i * i) : 0;
        }

        return count;
    }

    public bool Can(int i, string num_square, int num, int cur, int total) {
        if (i >= num_square.Length) {
            return total + cur == num;
        }

        var res = false;

        res = res || Can(i + 1, num_square, num, num_square[i] - '0', total + cur);
        res = res || Can(i + 1, num_square, num, cur * 10 + num_square[i] - '0', total);
        
        return res;
    } 
}