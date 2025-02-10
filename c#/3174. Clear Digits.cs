public class Solution {
    public string ClearDigits(string s) {
        LinkedList<char> list = new();
        foreach (var c in s) {
            if (char.IsDigit(c)) {
                if (list.Count > 0) list.RemoveLast();
            }
            else {
                list.AddLast(c);
            }
        }

        return string.Join("", list);
    }
}