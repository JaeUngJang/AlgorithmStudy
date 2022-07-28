using System.Text;
using System.Collections.Generic;

StringBuilder sb = new StringBuilder();
int T = int.Parse(Console.ReadLine());
List<(int, string)> memlist = new List<(int, string)>();

for (int i = 0; i < T; i++)
{
    string[] val = Console.ReadLine().Split(' ');
    memlist.Add((int.Parse(val[0]), val[1]));
}

var sortedlist = memlist.OrderBy(x => x.Item1).ToList();

for (int i = 0; i < sortedlist.Count; i++)
    sb.AppendLine(sortedlist[i].Item1.ToString() + " " + sortedlist[i].Item2);

Console.WriteLine(sb);
