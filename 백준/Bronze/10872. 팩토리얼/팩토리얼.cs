using System;

namespace Jae
{
    class Project
    {
        static int Recursion(int num)
        {
            if (num > 1)
                return Recursion(num - 1) * num;
            else if (num == 0) return 1;
            return num;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Recursion(num));
        }
    }
}