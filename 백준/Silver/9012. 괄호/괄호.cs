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
                Stack<char> stack = new Stack<char>();
                for (int i = 0; i < p.Length; i++)
                {
                    if (p[i] == '(')
                    {
                        stack.Push(p[i]);
                    }
                    else if (p[i] == ')')
                    {
                        if (stack.Count() == 0 || stack.Last() != '(')
                        {
                            valid = false;
                            break;
                        }
                        stack.Pop();
                    }
                }

                if (valid && stack.Count == 0)
                    sb.AppendLine("YES");
                else
                    sb.AppendLine("NO");
            }
            Console.WriteLine(sb);
        }
    }
}