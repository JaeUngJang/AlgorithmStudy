using System;
using System.Collections.Generic;

namespace Jae
{
    class Project
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            for (; cases > 0; cases--)
            {
                int k = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());

                List<int[]> building = new List<int[]>();

                int[] zfloor = new int[n], nfloor = new int[n];

                for (int i = 0; i < n; i++)
                    zfloor[i] = i + 1;

                building.Add(zfloor);

                for (int i = 0; i < k; i++)
                {
                    for (int j = 0; j < n; j++)
                        for (int l = 0; l <= j; l++)
                            nfloor[j] += building[i][l];
                    building.Add(nfloor);
                    nfloor = new int[n];
                }
                Console.WriteLine(building[k][n-1]);
            }

        }
    }
}