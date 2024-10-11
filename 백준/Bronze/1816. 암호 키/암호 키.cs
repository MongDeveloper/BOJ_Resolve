namespace CodingTest;
class Program
{
    static void Main(string[] args)
    {        
        var TC = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0; i < TC; i ++)
        {
            long number = Convert.ToInt64(Console.ReadLine());

            for(long j =2; j <= 1000000; j++)
            {
                if(number % j == 0)
                {
                    Console.WriteLine("NO");
                    break;
                }
                if(j == 1000000)
                {
                    Console.WriteLine("YES");
                }
            }            
        }


    }
}
