using System;

namespace Jae
{
    class Project
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (; K > 0; K--)
            {
                int temp = int.Parse(Console.ReadLine());
                if (temp == 0)
                    stack.Pop();
                else
                    stack.Push(temp);
            }

            Console.WriteLine(stack.Sum());
        }
    }
}