import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        StringBuilder sb = new StringBuilder();

        int n = Integer.parseInt(br.readLine());

        int[] fibo = new int[n + 1];
        fibo = fibonacci(fibo);

        sb.append(fibo[n]);

        System.out.println(sb);
    }
    
    public static int[] fibonacci(int[] fibo) {
        fibo[0] = 0;
        fibo[1] = 1;

        for (int i = 2; i < fibo.length; i++) {
            fibo[i] = fibo[i-2] + fibo[i-1];
        }

        return fibo;
    }

}