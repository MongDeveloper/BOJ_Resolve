string[] s = Console.ReadLine().Split(' ');

int N = int.Parse(s[0]); //5개바구니
int M = int.Parse(s[1]); //4번 공을 넣을 수 있는 기회

int[] baruni = new int[N]; //바구니갯수만큼 배열 선언

for (int i = 0; i < baruni.Length; i++)
{
    baruni[i] = 0;
}

for (int i = 0; i < M; i++)
{
    string[] ss = Console.ReadLine().Split(' ');
    int a = int.Parse(ss[0]);
    int b = int.Parse(ss[1]);
    int c = int.Parse(ss[2]);

    for (int j = a - 1; j < b; j++)
    {
        baruni[j] = c;
    }
}

for (int i = 0; i < N; i++)
{
    Console.Write($"{baruni[i]} ");
}