using System;
using System.Text;

namespace Jae
{
    class Project
    {
        static void Main(string[] args)
        {
            int size = 123456 * 2;
            bool[] prime = new bool[size + 1];

            for (int i = 2; i < prime.Length; i++)
                prime[i] = true; 

            for (int i = 2; i * i <= size; i++)
                if (prime[i])
                    for (int j = i * i; j <= size; j += i)
                        prime[j] = false;

            int n;
            StringBuilder sb = new StringBuilder();
            while ((n = int.Parse(Console.ReadLine())) != 0)
            {
                int start = n + 1, end = n * 2, count = 0;
                
                for (int i = start; i <= end; i++)
                    if (prime[i])
                        count++;

                sb.AppendLine(count.ToString());
            }
            Console.Write(sb);
        }
    }
}