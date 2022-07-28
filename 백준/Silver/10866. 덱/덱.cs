using System;
using System.IO;
using System.Collections.Generic;

namespace Jae
{
    class Project
    {
        static int Deque_Pop_F(ref LinkedList<int> deque)
        {
            int temp = deque.First();
            deque.RemoveFirst();
            return temp;
        }
        static int Deque_Pop_L(ref LinkedList<int> deque)
        {
            int temp = deque.Last();
            deque.RemoveLast();
            return temp;

        }

        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int T = int.Parse(Console.ReadLine());
            LinkedList<int> deque = new LinkedList<int>();

            for (; T > 0; T--)
            {
                string[] val = Console.ReadLine().Split(' ');
                switch (val[0])
                {
                    case "push_front": deque.AddFirst(int.Parse(val[1])); break;
                    case "push_back": deque.AddLast(int.Parse(val[1])); break;
                    case "pop_front": sw.WriteLine((deque.Count() == 0) ? -1 : Deque_Pop_F(ref deque)); break;
                    case "pop_back": sw.WriteLine((deque.Count() == 0) ? -1 : Deque_Pop_L(ref deque)); break;
                    case "front": sw.WriteLine((deque.Count() == 0) ? -1 : deque.First()); break;
                    case "back": sw.WriteLine((deque.Count() == 0) ? -1 : deque.Last()); break;
                    case "empty": sw.WriteLine((deque.Count() == 0) ? 1 : 0); break;
                    case "size": sw.WriteLine(deque.Count()); break;
                }
            }
            sw.Close();
        }
    }
}