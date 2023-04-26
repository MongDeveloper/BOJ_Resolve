string[] input = Console.ReadLine().Split(' ');
int cookMinutes = int.Parse(Console.ReadLine());

int hour = int.Parse(input[0]);
int minutes = int.Parse(input[1]);
int totalMinutes = (hour * 60) + minutes + cookMinutes;

int resultHour = totalMinutes / 60;
int resultMinutes = totalMinutes % 60;

Console.WriteLine($"{(resultHour >= 24 ? resultHour - 24 : resultHour)} {resultMinutes}");