using System;

public class Solution
{
    public int solution(int[] num_list)
    {
        int answer = 0;

        int multiple = 1;
        int sumsquare = 0;

        foreach (var item in num_list)
        {
            multiple *= item;
            sumsquare += item;
        }

        if (multiple < sumsquare * sumsquare)
            answer = 1;
        else
            answer = 0;


        return answer;
    }
}