using System;

namespace Jae
{
    class Project
    {
        static double Fac(double n, double r)
        {
            if (r == 0) return 1;
            else return (Fac(n, r - 1) * (n - r + 1) / r);
        }

        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (; T > 0; T--)
            {
                double[] rn = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
                double r = rn[0], n = rn[1];
                Console.WriteLine(Fac(n, r));
            }
        }
    }
}