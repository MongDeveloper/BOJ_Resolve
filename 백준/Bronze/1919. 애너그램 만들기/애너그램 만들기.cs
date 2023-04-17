string string1 = Console.ReadLine();
string string2 = Console.ReadLine();

var dic1 = new Dictionary<char, int>();

foreach(var c1 in string1.ToCharArray())
{
    if (dic1.ContainsKey(c1))
    {
        dic1[c1]++;
    }
    else
    {
        dic1.Add(c1, 1);
    }
}

var dic2 = new Dictionary<char, int>();

foreach (var c2 in string2.ToCharArray())
{
    if (dic2.ContainsKey(c2))
    {
        dic2[c2]++;
    }
    else
    {
        dic2.Add(c2, 1);
    }
}

int result = 0;
foreach(KeyValuePair<char, int> c1 in dic1)
{
    //dic2에 해당하는 키값이 있는지 확인, 있으면 Value-Value 진행, 없으면 dic1의 해당키의 Value 값 그대로 저장
    if(dic2.ContainsKey(c1.Key))
    {
        result += Math.Abs(c1.Value - dic2[c1.Key]);
    }
    else
    {
        result += c1.Value;
    }
}

foreach(KeyValuePair<char,int> c2 in dic2)
{
    if(dic1.ContainsKey(c2.Key))
    {

    }
    else
    {
        result += c2.Value;
    }
}

Console.WriteLine(result);