using System.Text;

StringBuilder sb = new StringBuilder();
int T = int.Parse(Console.ReadLine());
int[] nums = new int[T];
for (int i = 0; i < T; i++)
    nums[i] = int.Parse(Console.ReadLine());

Array.Sort(nums);

for (int i = 0; i < nums.Length; i++)
    sb.AppendLine(nums[i].ToString());

Console.WriteLine(sb);
