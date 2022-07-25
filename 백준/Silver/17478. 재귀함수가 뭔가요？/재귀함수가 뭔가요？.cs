using System;
using System.Text;

namespace Jae
{
    class Project
    {
        static int n;
        
        static string A(int num)
        {
            string tap = new string('_', num * 4);
            string end = tap + "라고 답변하였지.\n";

            if (num == 0) return end;
            else return end + A(num - 1);
        }

        static string Whatis(int num)
        {
            string a = "\"재귀함수가 뭔가요?\"\n";
            string b = "\"잘 들어보게. 옛날옛날 한 산 꼭대기에 이세상 모든 지식을 통달한 선인이 있었어.\n";
            string c = "마을 사람들은 모두 그 선인에게 수많은 질문을 했고, 모두 지혜롭게 대답해 주었지.\n";
            string d = "그의 답은 대부분 옳았다고 하네. 그런데 어느 날, 그 선인에게 한 선비가 찾아와서 물었어.\"\n";
            string last = "\"재귀함수는 자기 자신을 호출하는 함수라네\"\n";
            string tap = new string('_', num * 4);

            string sen = tap + a + tap + b + tap + c + tap + d;
            string lastsen = tap + a + tap + last;

            if (num == 0)
                return sen;
            else if(n == num)
                return Whatis(num - 1) + lastsen;
            else
                return Whatis(num - 1) + sen;
        }

        static void Main(string[] args)
        {
            string start = "어느 한 컴퓨터공학과 학생이 유명한 교수님을 찾아가 물었다.\n";

            n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            sb.Append(start);
            sb.Append(Whatis(n));
            sb.Append(A(n));

            Console.WriteLine(sb);
        }
    }
}