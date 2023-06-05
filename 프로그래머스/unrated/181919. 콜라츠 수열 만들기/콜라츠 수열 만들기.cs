using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int n)
    {
        List<int> list = new List<int>();
        list = Collatz(n, list);

        return list.ToArray();
    }

    public static List<int> Collatz(int n, List<int> list)
    {
        list.Add(n);

        if (n == 1)
        {
            return list;
        }            
        else if (n % 2 == 0)
        {
            n = n / 2;
            Collatz(n, list);
        }
        else
        {
            n = 3 * n + 1;
            Collatz(n, list);
        }        

        return list;
    }
}