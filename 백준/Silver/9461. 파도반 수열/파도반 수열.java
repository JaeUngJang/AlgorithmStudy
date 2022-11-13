import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.*;

public class Main {
    
    public static long[] arr;
    public static List<Integer> ns = new ArrayList();
    
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        StringBuilder sb = new StringBuilder();

        int T = Integer.parseInt(br.readLine());

        for (int i = 0; i < T; i++)
            ns.add(Integer.parseInt(br.readLine()));


        Integer max = Collections.max(ns);
        arr = new long[max];

        for (Integer n : ns) {
            sb.append(memo(n-1) + "\n");
        }

        System.out.println(sb);
    }
    
    public static Long memo(int n) {
        if      (n < 3) { arr[n] = 1L; }
        else if (n < 5) { arr[n] = 2L; }

        if (arr[n] == 0) {
            arr[n] = memo(n-1) + memo(n-5);
        }

        return arr[n];
    }

}