using System;

namespace Jae
{
    class Project
    {
        static void Main(string[] args)
        {
            int total = int.Parse(Console.ReadLine());
            int num = total, thr = 0, five = 0;

            if (num % 5 != 0)
            {
                five = Convert.ToInt32(Math.Truncate((double)num / 5));
                for (int i = 0; i <= 3; i++)
                {
                    if ((num - (((five - i) > 0? five - i: 0) * 5)) % 3 == 0)
                    {
                        five -= i;
                        thr = (num - five * 5) / 3;
                        goto Last;
                    }
                }
                five = -1;
            }
            else if (num % 5 == 0)
                five = num / 5;

            Last:
            Console.WriteLine(thr + five);
        }
    }
}