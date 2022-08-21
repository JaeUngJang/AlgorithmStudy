using System;
using System.Text;

namespace Jae
{
    class Project
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int T = int.Parse(Console.ReadLine());

            for (; T > 0; T--)
            {
                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int N = a[0], M = a[1], c = 0; // N : 문서 개수 || M : Order
                int[] w = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                Queue<int> q = new Queue<int>();
                
                for (int i = 0; i < N; i++)
                    q.Enqueue(w[i]);

                while (true)
                {
                    if (q.First() == q.Max() && M == 0)
                    {
                        c++;
                        break;
                    }
                    else if (q.First() == q.Max())
                    {
                        q.Dequeue();
                        c++;
                        M--;
                    }
                    else
                    {
                        q.Enqueue(q.Dequeue());
                        if (M - 1 < 0) M = q.Count - 1;
                        else M--;
                    }
                }
                sb.AppendLine(c.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
