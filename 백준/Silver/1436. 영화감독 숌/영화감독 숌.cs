using System;

namespace Jae
{
    class Project
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0, result = 0;

            for (int i = 666; count < n; i++)
            {
                string num = i.ToString();
                if (num.Contains("666"))
                    count++; result = i;
            }

            Console.WriteLine(result);
        }
    }
}