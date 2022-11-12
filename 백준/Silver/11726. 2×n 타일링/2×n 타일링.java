import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {
    public static int[] arr;

    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        StringBuilder sb = new StringBuilder();

        int n = Integer.parseInt(br.readLine());
        arr = new int[n + 1];
        c(n);
        int result = arr[n];

        sb.append(result);
        System.out.println(sb);
    }
    public static int c(int n) {
        if (n == 1) { arr[1] = 1; return 1; }
        if (n == 2) { arr[2] = 2; return 2; }

        if (arr[n] == 0) {
            arr[n] = (c(n - 1) + c(n - 2)) % 10007;
        }
        return arr[n];
    }
}