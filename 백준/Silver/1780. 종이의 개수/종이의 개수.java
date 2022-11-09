import java.io.*;
import java.util.Scanner;

public class Main {

    public static int no = 0; // -1
    public static int o  = 0; //  0
    public static int po = 0; // +1
    public static int[][] paperArr;
    
    public static void main(String[] args) throws NumberFormatException, IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        int n = Integer.parseInt(br.readLine());
        paperArr = new int[n][n];

        for (int i = 0; i < n; i++) {
            String[] ns = br.readLine().split(" ");
            for (int j = 0; j < n; j++) {
                paperArr[i][j] = Integer.parseInt(ns[j]);
            }
        }

        paperValid(0 ,0 ,n);

        System.out.println(no);
        System.out.println(o);
        System.out.println(po);
    }
    
    public static void paperValid(int row, int col, int size) {

        int validResult = colorValid(row, col, size);
        if (validResult != 2) {
            if (validResult == -1) {
                no++; return;
            } else if (validResult == 0) {
                o++;  return;
            } else if (validResult == 1) {
                po++; return;
            }
        }
        
        int s = size / 3;

        paperValid(row, col, s); // ( 0 , 0 )
        paperValid(row + s, col, s); // ( 1 , 0 )
        paperValid(row + s * 2, col, s); // ( 2 , 0 )

        paperValid(row, col + s, s); // ( 0 , 1 )
        paperValid(row + s, col + s, s); // ( 1 , 1 )
        paperValid(row + s * 2, col + s, s); // ( 2 , 1 )

        paperValid(row, col + s * 2, s); // ( 0 , 2 )
        paperValid(row + s, col + s * 2, s); // ( 1 , 2 )
        paperValid(row + s * 2, col + s * 2, s); // ( 2 , 2 )
    }
    
    public static int colorValid(int row, int col, int size) {

        int init = paperArr[row][col];
        
        for (int i = row; i < (row + size); i++) {
            for (int j = col; j < (col + size); j++) {
                if (paperArr[i][j] != init) {
                    return 2;
                }
            }
        }

        return init;
    }
}