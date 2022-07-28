using System;
using System.IO;

namespace Jae
{
    class Project
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int T = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (; T > 0; T--)
            {
                string[] val = Console.ReadLine().Split(' ');
                switch (val[0])
                {
                    case "push":  stack.Push(int.Parse(val[1])); break;
                    case "size":  sw.WriteLine(stack.Count()); break;
                    case "empty": sw.WriteLine((stack.Count() == 0) ? 1 : 0); break;
                    case "pop":   sw.WriteLine((stack.Count() == 0) ? -1 : stack.Pop()); break;
                    case "top":   sw.WriteLine((stack.Count() == 0) ? -1 : stack.First()); break;
                }
            }
            sw.Close();
        }
    }
}