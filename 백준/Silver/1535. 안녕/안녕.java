import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {
    
    public static int[][] val;
    public static int[][] dp;
    
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        StringBuilder sb = new StringBuilder();

        int N = Integer.parseInt(br.readLine());
        val = new int[N + 1][2];
        dp  = new int[N + 1][101];

        for (int i = 0; i < 2; i++) {
            String[] temp = br.readLine().split(" ");
            for (int j = 1; j <= N; j++) {
                val[j][i] = Integer.parseInt(temp[j - 1]);
            }
        }

        for (int i = 1; i <= N; i++) {
            for (int j = 1; j <= 100; j++) {
                if (val[i][0] <= j) {
                    dp[i][j] = Math.max(dp[i - 1][j], val[i][1] + dp[i - 1][j - val[i][0]]);
                } else {
                    dp[i][j] = dp[i - 1][j];
                }
            }
        }

        sb.append(dp[N][99]);
        System.out.println(sb);


    }
    
}