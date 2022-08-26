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
                char[] p = Console.ReadLine().ToCharArray();
                bool valid = true;
                int stack = 0;
                for (int i = 0; i < p.Length; i++)
                {
                    if (p[i] == '(')
                    {
                        stack++;
                    }
                    else if (p[i] == ')')
                    {
                        if (stack > 0)
                            stack--;
                        else
                        {
                            valid = false;
                            break;
                        }
                    }
                }

                if (valid && stack == 0)
                    sb.AppendLine("YES");
                else
                    sb.AppendLine("NO");
            }
            Console.WriteLine(sb);
        }
    }
}