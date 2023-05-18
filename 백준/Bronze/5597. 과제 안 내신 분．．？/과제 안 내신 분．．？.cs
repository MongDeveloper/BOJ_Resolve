Dictionary<int, int> dic = new Dictionary<int, int>();

for (int i = 1; i <= 28; i++)
{
    int a = int.Parse(Console.ReadLine());
    dic.Add(a, a);
}

List<int> list = new List<int>();
for (int i = 1; i <= 30; i++)
{
    if (!dic.ContainsKey(i))
        list.Add(i);
}

Console.WriteLine(list.Min());
Console.WriteLine(list.Max());