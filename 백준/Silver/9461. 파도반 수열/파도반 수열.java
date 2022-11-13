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
        tub(max);

        for (Integer n : ns) {
            sb.append(arr[n-1] + "\n");
        }

        System.out.println(sb);
    }
    
    public static void tub(int n) {
        for (int i = 0; i < n; i++) {
            if (i < 3) { arr[i] = 1L; }
            else if (i < 5) { arr[i] = 2L; }
            else {
                arr[i] = arr[i-1] + arr[i-5];
            }
        }
    }

}