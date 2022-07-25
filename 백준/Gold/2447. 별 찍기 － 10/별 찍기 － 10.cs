using System;
using System.Text;

namespace Jae
{
    class Project
    {
        static bool Star_Recur(int N, int i, int j)
        {
            if (N == 3) {
                if (i == 1 && j == 1) return false;
                else return true;
            }
            if (i / (N/3) == 1 && j / (N/3) == 1) return false;
            else return Star_Recur(N / 3, i % (N / 3), j % (N / 3));
        }
        
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (Star_Recur(N, i, j)) sb.Append("*");
                    else sb.Append(" ");
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb);
        }
    }
}