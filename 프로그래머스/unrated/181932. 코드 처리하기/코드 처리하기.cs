using System;

public class Solution
{
    public string solution(string code)
    {
        string answer = "";

        int mode = 0; //모드 관련        

        char[] chars = code.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] == '1')
            {
                mode = mode == 1 ? 0 : 1;
                continue;
            }
                
            //mode == 0일때 짝수만, mode == 1 이면 홀수만
            if ((mode == 0 && (i % 2 == 0)) || (mode == 1 && (i % 2 == 1)))
            {
                answer += chars[i];
            }
        }

        return answer == "" ? "EMPTY" : answer;
    }
}