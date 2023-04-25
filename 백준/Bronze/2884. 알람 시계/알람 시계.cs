string[] input = Console.ReadLine().Split(' ');

int hour = int.Parse(input[0]);
int minutes = int.Parse(input[1]);
int totalMinutes = hour * 60 + minutes;

if (totalMinutes < 45)
{
    totalMinutes += 60 * 24;
}

int resultMinutes = totalMinutes - 45;

Console.WriteLine($"{resultMinutes / 60} {resultMinutes % 60}");