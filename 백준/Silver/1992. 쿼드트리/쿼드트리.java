import java.io.*;
import java.util.Scanner;

public class Main {
    
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        StringBuilder sb = new StringBuilder();

        int n = Integer.parseInt(br.readLine());
        int[][] arr = new int[n][n];

        for (int i = 0; i < n; i++) {
            String temp = br.readLine();
            for (int j = 0; j < n; j++) {
                arr[i][j] = Integer.parseInt(String.valueOf(temp.charAt(j)));
            }
        }

        sb.append(quadTree(arr, 0, 0, n));
        System.out.println(sb);
    }
    
    public static String quadTree(int[][] arr, int row, int col, int size) {

        if (valid(arr, row, col, size) == true) {
            return String.format("%d", arr[row][col]);
        } else {
            int s = size/2;
            return "(" +
                    quadTree(arr, row, col, s) +
                    quadTree(arr, row, col + s, s) +
                    quadTree(arr, row + s, col, s) +
                    quadTree(arr, row + s, col + s, s) + ")";
        }
    }

    public static Boolean valid(int[][] arr, int row, int col, int size) {

        for (int i = row; i < (row + size); i++) {
            for (int j = col; j < (col + size); j++) {
                if (arr[i][j] != arr[row][col]) {
                    return false;
                }
            }
        }
        return true;
    }
}