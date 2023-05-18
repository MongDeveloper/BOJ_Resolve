using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(string[] arr)
    {
        Queue<string> queue = new Queue<string>();
        string answer = "";

        foreach(var item in arr)
        {
            queue.Enqueue(item);
        }

        foreach(var item in queue)
        {
            answer += item;
        }
        
        return answer;
    }
}
