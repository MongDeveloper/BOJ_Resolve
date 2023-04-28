string[] inputNumbers = Console.ReadLine().Split(' ');

int[] numbers = new int[inputNumbers.Length];
numbers[0] = int.Parse(inputNumbers[0]);
numbers[1] = int.Parse(inputNumbers[1]);
numbers[2] = int.Parse(inputNumbers[2]);

Dictionary<int, int> dic = new Dictionary<int, int>();

for (int i = 0; i < numbers.Length; i++)
{
    if (dic.ContainsKey(numbers[i]))
        dic[numbers[i]]++;
    else
        dic[numbers[i]] = 1;
}

//키값이 3개인지 2개인거가 있으면 거기에 Value를 찾고 만약 키값이 모두 1개이면 Max Value를 찾기

int maxValue = dic.Keys.Max();
int maxCount = 0;
int checkNumber = 0;
foreach(KeyValuePair<int, int> item in dic)
{
    if (maxCount <= item.Value)
    {
        maxCount = item.Value;
        checkNumber = item.Key;
    }
}

if(maxCount == 3)
{
    Console.WriteLine($"{checkNumber * 1000 + 10000}");
}
else if (maxCount == 2)
{
    Console.WriteLine($"{checkNumber * 100 + 1000}");
}
else
{
    Console.WriteLine($"{maxValue * 100}");
}