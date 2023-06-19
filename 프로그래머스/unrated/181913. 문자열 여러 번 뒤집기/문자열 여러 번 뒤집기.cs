using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(string my_string, int[,] queries)
    {
        string answer = my_string;

        for (int i = 0; i < queries.GetLength(0); i++)
        {
            int s = queries[i, 0];
            int e = queries[i, 1];

            Stack<char> stack = new Stack<char>();

            string front = s == 0 ? "" : answer.Substring(0, s);
            string before = answer.Substring(s, e - s + 1);
            string back = e == answer.Length - 1 ? "" : answer.Substring(e + 1, answer.Length - (e + 1));
            string after = "";

            foreach(var item in before)
            {
                stack.Push(item);
            }

            foreach(var item in stack)
            {
                after += item;
            }

            answer = string.Concat(front, after, back);
        }

        return answer;
    }
}