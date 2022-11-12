import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {
    
    public static int[] memo;

    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        StringBuilder sb = new StringBuilder();

        int n = Integer.parseInt(br.readLine());

        memo = new int[n];
        sb.append(memo(n));

        System.out.println(sb);
    }
    
    public static int memo(int n) {
        if (n == 1) { memo[n-1] = 1; return 1; }
        if (n == 2) { memo[n-1] = 1; return 1; }

        if (memo[n-1] == 0) {
            memo[n-1] = memo(n-1) + memo(n-2);
        }

        return memo[n-1];
    }

}