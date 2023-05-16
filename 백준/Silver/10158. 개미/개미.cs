string[] input = Console.ReadLine().Split(' ');
string[] startInput  = Console.ReadLine().Split(' ');
int T = int.Parse(Console.ReadLine());

int W = int.Parse(input[0]);
int H = int.Parse(input[1]);

int P = int.Parse(startInput[0]);
int Q = int.Parse(startInput[1]);


int timeX = T % (2 * W);
int currentX = P;
int deltaX = 1;

while(timeX-- > 0)
{
    if (currentX == W) deltaX = -1;
    else if (currentX == 0) deltaX = 1;

    currentX += deltaX;
}

int timeY = T % (2 * H);
int currentY = Q;
int deltaY = 1;

while(timeY-- > 0)
{
    if (currentY == H) deltaY = -1;
    else if (currentY == 0) deltaY = 1;

    currentY += deltaY;
}

Console.WriteLine($"{currentX} {currentY}");
