string[] numbers = Console.ReadLine().Split(' ');
int N = int.Parse(numbers[0]); //바구니숫자
int M = int.Parse(numbers[1]); //몇번

int[] baruni = new int[N];
for (int i = 0; i < N; i++)
{
    baruni[i] = i + 1;
}

//index  : 0 1 2 3 4
//number : 1 2 3 4 5

for (int i = 0; i < M; i++)
{
    string[] n = Console.ReadLine().Split(' ');
    int pi = int.Parse(n[0]);
    int pj = int.Parse(n[1]);

    //pi ~ pj 자리 값만큼 queue에 넣기, 빼서 다시 넣어주기

    Stack<int> stack = new Stack<int>();
    //q에 넣기
    for (int j = pi; j <= pj; j++)
    {
        stack.Push(baruni[j-1]);
    }

    //q에서 빼기
    for (int j = pi; j <= pj; j++)
    {
        baruni[j - 1] = stack.Pop();
    }
}

Console.WriteLine(string.Join(" ", baruni));