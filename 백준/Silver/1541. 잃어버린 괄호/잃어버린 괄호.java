import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        String cal = br.readLine();
        String[] section = cal.split("-");

        int posSum = 0;
        int negSum = 0;

        String[] pos = section[0].split("\\+");

        for (String s : pos) {
            posSum += Integer.parseInt(s);
        }

        for (int i = 1; i < section.length; i++) {
            String[] temp = section[i].split("\\+");
            for (String s : temp) {
                negSum += Integer.parseInt(s);
            }
        }

        System.out.println(posSum - negSum);
    }
}