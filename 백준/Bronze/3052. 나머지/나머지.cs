int[] numbers = new int[10];

for (int i = 0; i < numbers.Length; i++)
{
    int n = int.Parse(Console.ReadLine());

    numbers[i] = n;
}

Dictionary<int, int> dic = new Dictionary<int, int>();
for (int i = 0; i < numbers.Length; i++)
{
    int remainder = numbers[i] % 42;

    if (!dic.ContainsKey(remainder))
        dic.Add(remainder, remainder);
}

Console.WriteLine(dic.Count);