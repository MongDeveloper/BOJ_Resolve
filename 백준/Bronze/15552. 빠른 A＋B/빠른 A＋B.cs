using System.Text;

int T = int.Parse(Console.ReadLine());

string[] input = new string[2];
int a = 0;
int b = 0;
StringBuilder sb = new StringBuilder();

for(int i = 0; i < T; i++)
{
    input = Console.ReadLine().Split(' ');
    a = int.Parse(input[0]);
    b = int.Parse(input[1]);

    sb.Append($"{a + b}\n");
}

Console.WriteLine(sb.ToString());