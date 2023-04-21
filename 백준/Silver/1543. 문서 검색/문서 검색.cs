//1. 문자입력받기
//2. 두번째 문자 입력받기
//3. 왼쪽부터 substring 해서 하나씩 뺀다음에 총 몇개인지 파악, index로 찾을 수 있는데
string a = Console.ReadLine();
string b = Console.ReadLine();

int count = 0;

for (int i = 0; i < a.Length; i++)
{
    if(i + b.Length > a.Length)
    {
        break;
    }

    if(a.Substring(i, b.Length).Equals(b))
    {
        count++;
        i = i + (b.Length - 1);
    }
}

Console.WriteLine(count);