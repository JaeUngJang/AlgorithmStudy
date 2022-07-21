using System;

namespace Jae
{
    class Project
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            int[] num = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int count = num.Length;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == 1) count--;
                else if (num[i] == 2) continue;
                else {
                    for (int j = 2; j < num[i]; j++)
                    {
                        if (num[i] % j == 0)
                        {
                            count--;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}