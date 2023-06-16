using System;

public class Solution
{
    public int solution(string number)
    {
        int answer = 0;

        int sum = 0;
        foreach(var item in number) {
            sum += int.Parse(item.ToString());
        }

        answer = sum % 9;

        return answer;
    }
}