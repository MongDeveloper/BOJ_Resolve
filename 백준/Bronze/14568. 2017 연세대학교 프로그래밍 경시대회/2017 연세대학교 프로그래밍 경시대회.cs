namespace CodingTest;
class Program
{
    static void Main(string[] args)
    {                
        var candy = Convert.ToInt32(Console.ReadLine());
        
        int testCount = 0;
        for(int A = 0; A < candy; A++)
        {
            for(int B=0; B<candy;B++)
            {
                for(int C=0;C<candy;C++)
                {
                    if(A + B + C == candy) //모두 다 해서 6개
                    {
                        if(A >= B+2)
                        {
                            if(A != 0 && B != 0 && C != 0)
                            {
                                if(C%2 == 0)
                                {
                                    testCount++;
                                }
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine(testCount);        
    }
}
