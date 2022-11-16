import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {
    
    public static int[][] val;
    public static int[][] result;

    public static void main(String[] args) throws IOException {
        
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        StringBuilder sb = new StringBuilder();

        int N  = Integer.parseInt(br.readLine());
        val    = new int[N][3];
        result = new int[N][3];


        for (int i = 0; i < N; i++) {
            String[] temp = br.readLine().split(" ");
            for (int j = 0; j < 3; j++) {
                val[i][j] = Integer.parseInt(temp[j]);
            }
        }

        result[0][0] = val[0][0];
        result[0][1] = val[0][1];
        result[0][2] = val[0][2];


        tub(N);

        int r = result[N-1][0];
        int g = result[N-1][1];
        int b = result[N-1][2];
        int min = (r >= g) ? ((g >= b) ? b : g) : ((r >= b) ? b : r);

        sb.append(min);
        System.out.println(sb);
    }
    
    public static void tub(int N) {
        for (int i = 1; i < N; i++) {
            for (int j = 0; j < 3; j++) {
                if (j == 0) {
                    result[i][j] = ((result[i-1][1] >= result[i - 1][2]) ? result[i - 1][2] : result[i-1][1]) + val[i][j];
                } else if (j == 1) {
                    result[i][j] = ((result[i-1][0] >= result[i - 1][2]) ? result[i - 1][2] : result[i-1][0]) + val[i][j];
                } else if (j == 2) {
                    result[i][j] = ((result[i-1][0] >= result[i - 1][1]) ? result[i - 1][1] : result[i-1][0]) + val[i][j];
                }
            }
        }
    }
    
}