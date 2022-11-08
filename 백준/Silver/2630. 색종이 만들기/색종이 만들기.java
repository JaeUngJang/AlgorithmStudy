import java.util.Scanner;

public class Main {
    
    public static int white = 0;
    public static int blue = 0;
    public static int[][] arr;
    
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        
        int n = in.nextInt();
        arr = new int[n][n];
        
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++){
                arr[i][j] = in.nextInt();
            }
        }

        paperCheck(0, 0, n);
        
        System.out.println(white);
        System.out.println(blue);   
    }
    
    public static void paperCheck(int row, int col, int n) {
        if (colorCheck(row, col, n)) {
            if (arr[row][col] == 0) { white++; }
            else { blue++; }
            return;
        }

        paperCheck(row, col, n/2);
        paperCheck(row, col + n/2, n/2);
        paperCheck(row + n/2, col, n/2);
        paperCheck(row + n/2, col + n/2, n/2);
    }
    
    public static Boolean colorCheck(int row, int col, int n) {
        int c = arr[row][col];
        for (int i = row; i < (n + row); i++) {
            for (int j = col; j < (n + col); j++) {
                if (c != arr[i][j]) { return false; }
            }
        }
        return true;
    }
}