using System;

public class Solution
{
    public string solution(int[] numLog)
    {
        string answer = "";

        for (int i = 1; i < numLog.Length; i++)
        {
            int result = 0;

            result = numLog[i] - numLog[i - 1];

            if (result == 1)
                answer += "w";
            if (result == -1)
                answer += "s";
            if (result == 10)
                answer += "d";
            if (result == -10)
                answer += "a";
        }

        return answer;
    }    
}