import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {
    public static void main(String[] args) throws NumberFormatException, IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        String[] nums = br.readLine().split(" ");

        long A = Long.parseLong(nums[0]), B = Long.parseLong(nums[1]), C = Long.parseLong(nums[2]);
        long remainder = remainder(A, B, C);

        System.out.println(remainder);
    }
    
    public static long remainder(long A, long B, long C) {
        // 나머지 연산자 분할법칙
        // (A + B) % C = ((A % C) + (B % C)) % C
        // (A * B) % C = ((A % C) * (B % C)) % C
        // (A - B) % C = ((A % C) - (B % C) + C) % C

        // (A ^ B) % C = ((A % C) * (A ^ ((B - 1) % C))               ) % C
        //             =            ((A % C) * (A ^ (B - 2)) % C) % C
        //             =                  ...
        //             =                       ( A ^ 1 % C)

        if (B == 1) { return A % C; }
        long remainder = remainder(A, B / 2, C);
        if (B % 2 == 0) {
            return remainder * remainder % C;
        } else {
            return (remainder * remainder) % C * A % C;
        }
    }   
}