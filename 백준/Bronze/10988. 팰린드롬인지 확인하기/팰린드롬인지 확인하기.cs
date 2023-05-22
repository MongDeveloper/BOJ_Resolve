string word = Console.ReadLine();

//원래 단어와 stack 넣어서 빼는 단어와 비교
Stack<char> stack = new Stack<char>();

foreach(var item in word)
{
    stack.Push(item);
}

int answer = 1;
foreach(var item in word)
{
    if(item != stack.Pop())
    {
        answer = 0;
    }
}

Console.WriteLine(answer);