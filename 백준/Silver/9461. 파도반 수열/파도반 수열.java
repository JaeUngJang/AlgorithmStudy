import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {
    
    public static long[] arr;
    
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        StringBuilder sb = new StringBuilder();

        int T = Integer.parseInt(br.readLine());

        for (; T > 0; T--) {
            int n = Integer.parseInt(br.readLine());
            arr = new long[n];
            
            tub(n);
            
            sb.append(arr[n-1] + "\n");
        }

        System.out.println(sb);
    }
    
    public static void tub(int n) {
        for (int i = 0; i < n; i++) {
            if (i < 3) { arr[i] = 1; }
            else if (i < 5 && i >= 3) { arr[i] = 2; }
            else {
                arr[i] = arr[i-1] + arr[i-5];
            }
        }
    }

}