Dictionary<int, int> dic = new Dictionary<int, int>();

for (int i = 1; i <= 9; i++)
{
    int a = int.Parse(Console.ReadLine());
    dic.Add(a, i);
}

int maxValue = dic.Keys.Max();

Console.WriteLine(maxValue);
Console.WriteLine(dic[maxValue]);