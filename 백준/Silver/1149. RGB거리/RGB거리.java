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


        int r = memo(N-1, 0);
        int g = memo(N-1, 1);
        int b = memo(N-1, 2);

        int a = (r >= g) ? ((g >= b) ? b : g) : ((r >= b) ? b : r);

        sb.append(a);
        System.out.println(sb);
    }
    
    public static int memo(int N, int rgb) {

        if (result[N][rgb] == 0) {
            if (rgb == 0) {
                result[N][rgb] = ((memo(N-1, 1) >= memo(N-1, 2)) ? memo(N-1, 2) : memo(N-1, 1)) + val[N][rgb];
            } else if (rgb == 1) {
                result[N][rgb] = ((memo(N-1, 0) >= memo(N-1, 2)) ? memo(N-1, 2) : memo(N-1, 0)) + val[N][rgb];
            } else if (rgb == 2) {
                result[N][rgb] = ((memo(N-1, 0) >= memo(N-1, 1)) ? memo(N-1, 1) : memo(N-1, 0)) + val[N][rgb];
            }
        }
        return result[N][rgb];
    }
    
}