using System;

namespace Jae
{
    class Project
    {
        static int ChessBoardCheck(bool[,] wbbw, bool[,] board, int w, int h)
        {
            int min = 8 * 8;

            for (int i = 0; i <= h - 8; i++)         //h
            {
                for (int j = 0; j <= w - 8; j++)     //w
                {
                    int wbc = 0;
                    for (int n = 0; n < 8; n++)     //h
                    {
                        for (int m = 0; m < 8; m++) //w
                        {
                            if (board[i + n, j + m] != wbbw[n, m])
                            {
                                wbc++;
                            }
                        }
                        if (wbc > min)
                            break;
                    }
                    if (wbc < min)
                        min = wbc;
                }
            }

            return min;
        }

        static void Main(string[] args)
        {
            bool[,] WB = new bool[8,8];
            bool[,] BW = new bool[8,8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    WB[i, j] = (i % 2 == 0) ? ((j % 2 == 0) ? true : false) : ((j % 2 == 0) ? false : true);
                    BW[i, j] = (i % 2 == 0) ? ((j % 2 == 0) ? false : true) : ((j % 2 == 0) ? true : false);
                }
            }

            int[] WH = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int h = WH[0], w = WH[1];
            bool[,] given  = new bool[h, w];
            for (int i = 0; i < h; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < line.Length; j++)
                    given[i, j] = (line[j] == 'W')? true : false;
            }

            int wbmin = ChessBoardCheck(WB, given, w, h);
            int bwmin = ChessBoardCheck(BW, given, w, h);

            Console.WriteLine((wbmin <= bwmin) ? wbmin : bwmin);
        }
    }
}