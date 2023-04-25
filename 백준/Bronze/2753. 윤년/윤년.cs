int year = int.Parse(Console.ReadLine());

int result = 0;

if (year % 400 == 0)
{
    result = 1;
}
else if (year % 4 == 0 && year % 100 > 0)
{
    result = 1;
}
else
{
    result = 0;
}

Console.WriteLine(result);