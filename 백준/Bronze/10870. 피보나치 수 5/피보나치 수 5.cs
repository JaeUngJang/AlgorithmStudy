using System;

namespace Jae
{
    class Project
    {
        static int Fibo(int n)
        {
            if      (n < 1) return 0;
            else if (n == 1 || n == 2) return 1;
            else    return Fibo(n - 1) + Fibo(n - 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Fibo(int.Parse(Console.ReadLine())));
        }
    }
}