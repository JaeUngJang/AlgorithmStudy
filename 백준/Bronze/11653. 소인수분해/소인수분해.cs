using System;
using System.Text;

namespace Jae
{
    class Project
    {
        static void Main(string[] args) 
        {
            StringBuilder sb = new StringBuilder();
            int num = int.Parse(Console.ReadLine());

            if (num != 1)
            {
                int primenum = 2;

                GetInitPrime(ref primenum, num);

                while (num % primenum == 0)
                {
                    Begin:
                    if (num % primenum == 0)
                    {
                        if (num / primenum != 1)
                        {
                            num = num / primenum;
                            sb.AppendLine(primenum.ToString());
                            goto Begin;
                        }
                        else goto Last;
                    }
                    GetInitPrime(ref primenum, num);
                }
                Last:
                sb.AppendLine(num.ToString());
            }

            Console.Write((sb==null)?null:sb.ToString());
            Console.ReadLine();
        }

        static void GetInitPrime(ref int prime, int num)
        {
            if (num % 2 == 0) { prime = 2; return; }

            for (int i = 3; i <= Math.Sqrt(num); i+=2)
            {
                if (num % i == 0)
                {
                    prime = i;
                    return;
                }
            }
            prime = num;
        }
    }
}