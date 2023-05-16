string[] s = Console.ReadLine().Split(' ');

int N = int.Parse(s[0]); //5개바구니
int M = int.Parse(s[1]); //4번 공을 넣을 수 있는 기회

int[] baruni = new int[N]; //바구니갯수만큼 배열 선언

for (int i = 0; i < baruni.Length; i++)
{
    baruni[i] = i + 1;
}

for (int i = 0; i < M; i++)
{
    string[] ss = Console.ReadLine().Split(' ');
    int a = int.Parse(ss[0]);
    int b = int.Parse(ss[1]);    

    Swap(baruni, a, b);
}

for (int i = 0; i < N; i++)
{
    Console.Write($"{baruni[i]} ");
}

static void Swap(int[] baruni, int a, int b)
{
    int temp = baruni[a - 1];
    baruni[a - 1] = baruni[b - 1];
    baruni[b - 1] = temp;
}