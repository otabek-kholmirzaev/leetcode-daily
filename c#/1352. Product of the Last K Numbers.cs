public class ProductOfNumbers {
    List<int> A;

    public ProductOfNumbers() {
        A = new();
        A.Add(1);
    }
    
    public void Add(int num) {
        if (num == 0) {
            A = new();
            A.Add(1);
        }
        else {
            A.Add(A[A.Count - 1] * num);
        }
    }
    
    public int GetProduct(int k) {
        int n = A.Count;
        return n > k ? A[n - 1] / A[n - 1 - k] : 0;
    }
}