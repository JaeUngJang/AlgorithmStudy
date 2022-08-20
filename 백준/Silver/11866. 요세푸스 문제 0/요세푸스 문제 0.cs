using System;
using System.Text;
using System.Collections.Generic;

namespace Jae
{
    class Project
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(); sb.Append("<");
            int[] n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int T = n[0], d = n[1], curidx = 0;

            Queue<int> list = new Queue<int>(Enumerable.Range(1, T));

            while (list.Count > 0)
            {
                curidx++;
                if (curidx == d)
                {
                    if (list.Count == 1)
                        sb.Append(string.Format("{0}>", list.Dequeue()));
                    else
                        sb.Append(string.Format("{0}, ", list.Dequeue()));

                    curidx = 0;
                }
                else
                {
                    list.Enqueue(list.Dequeue());
                }
            }

            Console.WriteLine(sb);

        }
    }
}