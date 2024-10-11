namespace CodingTest;
class Program
{
    static void Main(string[] args)
    {                
        string[] numbers = Console.ReadLine().Split();

        int a = Convert.ToInt32(numbers[0]);
        int b = Convert.ToInt32(numbers[1]);
        int c = Convert.ToInt32(numbers[2]);
        int d = Convert.ToInt32(numbers[3]);
        int e = Convert.ToInt32(numbers[4]);
        int f = Convert.ToInt32(numbers[5]);        

        for(int x = -999; x<= 999; x++)
        {
            for(int y = -999; y <= 999; y++)
            {
                if((a*x + b*y == c) && (d*x + e*y == f))
                {
                    Console.WriteLine($"{x} {y}");
                }
            }
        }
    }
}
