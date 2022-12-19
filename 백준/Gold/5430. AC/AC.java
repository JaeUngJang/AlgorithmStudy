import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Deque;
import java.util.LinkedList;

class Main {
    
    static StringBuilder sb = new StringBuilder();

    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        int T = Integer.parseInt(br.readLine());
        
        for (; T > 0; T--) {
            String p = br.readLine();         // 수행할 함수
            Integer.parseInt(br.readLine());  // 배열에 들어가있는 수의 개수
            String str = br.readLine();       // 정수 배열

            // 문자열 파싱
            str = str.substring(1, str.length() - 1);
            String[] ns = str.split(",");

            // Deque 입력
            Deque<Integer> deque = new LinkedList<>();

            for (String s : ns)
                if (s != null && s != "")
                    deque.add(Integer.parseInt(s));


            // p 수행
            Boolean fl = true;      // true : front, false : last
            Boolean error = false;  // error 발생 : true

            for (int i = 0; i < p.length(); i++) {
                if (p.charAt(i) == 'R') {
                    fl = !fl;
                    continue;
                }

                // D인 경우
                if (fl) {
                    if (deque.pollFirst() == null) {
                        error = true;
                        break;
                    }
                } else {
                    if (deque.pollLast() == null) {
                        error = true;
                        break;
                    }
                }
            }

            if (error == true) {
                sb.append("error").append("\n");
                continue;
            }

            sb.append("[");
            if (deque.size() > 0) {
                if (fl) {
                    sb.append(deque.pollFirst());
                    while (!deque.isEmpty()) {
                        sb.append(',').append(deque.pollFirst());
                    }
                } else {
                    sb.append(deque.pollLast());
                    while (!deque.isEmpty()) {
                        sb.append(',').append(deque.pollLast());
                    }
                }
            }
            sb.append(']').append('\n');
        }
        System.out.println(sb.toString());
    }
}