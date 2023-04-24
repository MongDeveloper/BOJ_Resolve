//1.시간 입력받기
//2.시간 입력받기
//시간 타입으로 변경하고 차이를 출력할 것 //
string s1 = Console.ReadLine();
string s2 = Console.ReadLine();

DateTime dt1 = DateTime.Parse($"2023-04-21 {s1}");
DateTime dt2 = DateTime.Parse($"2023-04-21 {s2}");

if (DateTime.Compare(dt1, dt2) >= 0)
{
    dt2 = dt2.AddDays(1);
}

int diffSeconds = (int)(dt2 - dt1).TotalSeconds;

int resultHour = diffSeconds / (60 * 60);
int resultMinutes = (diffSeconds % (60 * 60)) / 60;
int resultSeconds = (diffSeconds % (60 * 60)) % 60;

Console.WriteLine($"{resultHour:D2}:{resultMinutes:D2}:{resultSeconds:D2}");