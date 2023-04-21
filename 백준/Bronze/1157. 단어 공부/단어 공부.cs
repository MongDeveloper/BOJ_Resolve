//문자입력받기
//대문자로변경, 나중에 출력을 대문자로 하기 때문에
//Dic 또는 배열을 통해 각각 알파벳이 몇개 있는지 체크
//가장 많이 사용된 알파벳이 여러개 존재하면 ? 아니면 대문자로 출력

string a = Console.ReadLine().ToUpper();

int[] c = new int[26];

//최대 백만번
for (int i = 0; i < a.Length; i++)
{
    c[a[i] - 'A']++;
}

int checkCount = 0;
char checkAlpha = 'A';
for (int i = 0; i < c.Length; i++)
{
    if (c.Max() <= c[i])
    {
        checkAlpha = (char)(i + 'A');
        checkCount++;
    }
}

Console.WriteLine(checkCount > 1 ? "?" : checkAlpha);