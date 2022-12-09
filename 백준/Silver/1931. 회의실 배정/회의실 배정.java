import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.*;

class Main {
    
    public static void main(String[] args) throws IOException{
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        int N = Integer.parseInt(br.readLine());

        int[][] meetings = new int[N][2];

        for (int i = 0; i < N; i++) {
            String[] t = br.readLine().split(" ");
            meetings[i][0] = Integer.parseInt(t[0]);
            meetings[i][1] = Integer.parseInt(t[1]);
        }

        Arrays.sort(meetings, new Comparator<int[]>() {
            @Override
            public int compare(int[] m1, int[] m2) {
                return (m1[1] != m2[1]) ? m1[1] - m2[1] : m1[0] - m2[0];
                // 두 번째 숫지를 기준으로 내림차순 정렬
                // 만약 두 번째 숫자가 같다면 첫 번째 숫자로 내림차순 정렬
            }
        });

        int count = 0;
        int et = 0;

        for (int i = 0; i < N; i++) {
            if (meetings[i][0] >= et) {
                count++;
                et = meetings[i][1];
            }
        }

        System.out.println(count);
    }
}