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
            int[] list = new int[T], list_count= new int[8001];

            for (int i = 0; i < T; i++)
            {
                list[i] = int.Parse(Console.ReadLine());
                list_count[4000 + list[i]]++;
            }

            Array.Sort(list);

            // 1. 산술평균 : N개의 수들의 합을 N으로 나눈 값
            sb.AppendLine(((int)Math.Round((double)list.Sum() / list.Count())).ToString());

            // 2. 중앙값 : N개의 수들을 증가하는 순서로 나열했을 경우 그 중앙에 위치하는 값
            sb.AppendLine(list[(list.Length - 1) / 2].ToString());

            // 3. 최빈값 : N개의 수들 중 가장 많이 나타나는 값
            int maxval = Int32.MinValue, t = 0;
            for (int i = 0; i < list_count.Count(); i++)
            {
                if (list_count[i] == list_count.Max())
                {
                    if (t > 1) break;
                    maxval = i - 4000;
                    t++;
                }
            }
            sb.AppendLine(maxval.ToString());

            // 4. 범위 : N개의 수들 중 최댓값과 최솟값의 차이
            sb.AppendLine((list[list.Length - 1] - list[0]).ToString());

            Console.WriteLine(sb);
        }
    }
}