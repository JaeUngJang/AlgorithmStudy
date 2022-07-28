using System;
using System.IO;
using System.Collections.Generic;

namespace Jae
{
    class Project
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int T = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();

            for (; T > 0; T--)
            {
                string[] val = Console.ReadLine().Split(' ');
                switch (val[0])
                {
                    case "push": queue.Enqueue(int.Parse(val[1])); break;
                    case "size": sw.WriteLine(queue.Count()); break;
                    case "empty": sw.WriteLine((queue.Count() == 0) ? 1 : 0); break;
                    case "back": sw.WriteLine((queue.Count() == 0) ? -1 : queue.Last()); break;
                    case "pop": sw.WriteLine((queue.Count() == 0) ? -1 :queue.Dequeue()); break;
                    case "front": sw.WriteLine((queue.Count() == 0) ? -1 : queue.First()); break;
                }
            }
            sw.Close();
        }
    }
}
