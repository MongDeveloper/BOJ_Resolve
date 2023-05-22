using System;

public class Solution
{
    public int solution(int a, int d, bool[] included)
    {
        int answer = 0;
        int[] data = new int[included.Length];

        for (int i = 0; i < included.Length; i++)
        {
            if (i == 0)
                data[i] = a;
            else
                data[i] = data[i - 1] + d;

            if (included[i])
            {
                answer += data[i];
            }
        }

        return answer;
    }
}