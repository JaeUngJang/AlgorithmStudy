using System;
using System.Text;

namespace Jae
{
    class Project
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int num = nums[0], end = nums[1];

            Begin:
            while (num <= end)
            {
                if (num == 1) { num++; continue; }
                else if (num == 2) goto End;
                else if (num % 2 == 0) { num++; continue; }

                for (int i = 3; i <= Math.Sqrt(num); i += 2)
                {
                    if (num % i == 0)
                    {
                        if (num % 2 == 0) num++;
                        else num += 2;
                        goto Begin;
                    }
                }
                End:

                 sb.AppendLine(num.ToString());

                if (num % 2 == 0) num++;
                else num += 2;
            }

            Console.Write(sb);
        }
    }
}