using System.Text;
int a = Convert.ToInt32(Console.ReadLine());

StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
StringBuilder sb = new StringBuilder();
for (; a > 0; a--)
{
    sb.AppendLine(a.ToString());
}
sw.Write(sb);
sw.Close();