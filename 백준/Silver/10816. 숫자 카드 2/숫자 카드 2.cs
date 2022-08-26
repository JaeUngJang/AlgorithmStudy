using System;
using System.Text;

namespace Jae
{
    class Project
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            Console.ReadLine();
            int[] n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var temp = n.GroupBy(x => x).ToArray();
            
            Console.ReadLine();
            int[] m = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Dictionary<int, int> dictionary = temp.ToDictionary(x => x.Key, x => x.Count());

            foreach (int i in m)
            {
                if (dictionary.ContainsKey(i))
                    sb.Append(dictionary[i]);
                else
                    sb.Append("0");

                sb.Append(" ");
            }

            Console.WriteLine(sb);
        }
    }
}