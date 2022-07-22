using System;
using System.Text;

namespace Jae
{
    class Project
    {
        static void Main(string[] args)
        {
            int size = 10000;
            bool[] prime = new bool[size + 1];
            for (int i = 2; i < prime.Length; i++)
                prime[i] = true; 
            for (int i = 2; i * i <= size; i++)
                if (prime[i])
                    for (int j = i * i; j <= size; j += i)
                        prime[j] = false;

            StringBuilder sb = new StringBuilder();
            int T = int.Parse(Console.ReadLine());
            while (T > 0)
            {
                T--;
                int n = int.Parse(Console.ReadLine());
                int x = 0, y = 0;

                for (int i = 2; i <= n / 2; i++)
                    if (prime[i])
                        x = y = i;

                for (int i = x; i >= 2; i-=2)
                    if (prime[i])
                        for (int j = y; j <= n; j+=2)
                            if (prime[j] && i + j == n)
                            {
                                x = j;
                                y = i;
                                goto End;
                            }
                End:;

                sb.AppendLine((x > y) ? y + " " + x : y + " " + x);
            }
            Console.WriteLine(sb);
        }
    }
}