using System;
using System.Numerics;

namespace Jae
{
    class Project
    {
        static void Main(string[] args)
        {
            BigInteger[] num = Array.ConvertAll(Console.ReadLine().Split(' '), BigInteger.Parse);
            Console.WriteLine(num[0] + num[1]);
        }
    }
}