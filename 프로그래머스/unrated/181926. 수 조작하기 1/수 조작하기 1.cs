using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int n, string control)
    {
        int answer = n;

        Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach(var item in control)
        {
            if (dict.ContainsKey(item))
                dict[item]++;
            else
                dict[item] = 1;
        }

        foreach(KeyValuePair<char, int> pair in dict)
        {
            switch (pair.Key)
            {
                case 'w':
                    answer += pair.Value * 1;
                    break;
                case 's':
                    answer += pair.Value *- 1;
                    break;
                case 'd':
                    answer += pair.Value * 10;
                    break;
                case 'a':
                    answer += pair.Value * -10;
                    break;
            }
        }

        return answer;
    }
}