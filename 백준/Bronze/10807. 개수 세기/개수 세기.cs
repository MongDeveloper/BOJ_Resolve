int N = int.Parse(Console.ReadLine());
string[] a = Console.ReadLine().Split(' ');
int v = int.Parse(Console.ReadLine());

int checkCount = 0;
foreach (var item in a)
{
    if (v == int.Parse(item))
    { checkCount++; }
}

Console.WriteLine(checkCount);