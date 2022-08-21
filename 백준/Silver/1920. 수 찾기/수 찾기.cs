using System;
using System.Text;

namespace Jae
{
    class Project
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Console.ReadLine();
            int[] N = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Console.ReadLine();
            int[] M = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            
            for (int i = 0; i < M.Length; i++)
            {
                if (N.Contains(M[i]))
                    sb.AppendLine("1");
                else
                    sb.AppendLine("0");
            }

            Console.WriteLine(sb);
        }
    }
}