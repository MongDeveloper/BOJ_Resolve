using System.Collections.Generic;
using System;

public class Solution
{
    public string solution(string str1, string str2)
    {
        Queue<char> queue = new Queue<char>();
        char[] chars1 = str1.ToCharArray();
        char[] chars2 = str2.ToCharArray();

        string answer = "";

        for(int i= 0; i < chars1.Length; i++)
        {            
            queue.Enqueue(chars1[i]);            
            queue.Enqueue(chars2[i]);
        }

        foreach(var item in queue)
        {
            answer += item;
        }

        return answer;
    }
}