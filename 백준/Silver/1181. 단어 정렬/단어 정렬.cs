using System;
using System.Text;

namespace Jae
{
    class Project
    {
        static void Main(string[] args)
        {
            int wordcount = int.Parse(Console.ReadLine());
            string[] wordlist = new string[wordcount];
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < wordcount; i++)
                wordlist[i] = Console.ReadLine();

            wordlist = wordlist.OrderBy(x => x).OrderBy(x => x.Length).Distinct().ToArray();

            foreach (string word in wordlist)
                sb.AppendLine(word);

            Console.WriteLine(sb);
        }
    }
}