using System;

namespace Jae
{
    class Project
    {
        static bool PrimeChecker(int num)
        {
            if (num == 1) return false;
            if (num % 2 == 0 && num != 2) return false;
            for (int i = 3; i <= Math.Sqrt(num); i += 2)
                if (num % i == 0)
                    return false;
            return true;
        }

        static void Main(string[] args)
        {
            int fromN = int.Parse(Console.ReadLine());
            int toN = int.Parse(Console.ReadLine());

            int[] prime = new int[toN - fromN + 1];
            for (int i = fromN; i <= toN; i++)
                prime[i - fromN] = i;

            for (int i = 0; i < prime.Length; i++)
                if (!PrimeChecker(prime[i]))
                    prime[i] = 0;

            prime = prime.Distinct().ToArray();
            Array.Sort(prime);

            Console.WriteLine((prime.Sum() != 0) ? (prime.Sum() + "\n" + ((prime[0] == 0)?prime[1]:prime[0])) : "-1");
        }
    }
}