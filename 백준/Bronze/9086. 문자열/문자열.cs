int T = int.Parse(Console.ReadLine());

string[] answer = new string[T];
for (int i = 0; i < T; i++)
{
    string testcase = Console.ReadLine();

    answer[i] = $"{testcase.Substring(0, 1)}{testcase.Substring(testcase.Length - 1, 1)}";    
}

foreach(var item in answer)
{
    Console.WriteLine(item);
}    