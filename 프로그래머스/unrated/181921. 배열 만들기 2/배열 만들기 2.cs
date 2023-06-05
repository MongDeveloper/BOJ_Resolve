using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int l, int r)
    {        
        //1. 5의배수만, 최대를 20만으로 줄일 수 있음
        List<string> list = new List<string>();
        for (int i = l; i <= r; i++)
        {
            if (i % 5 == 0)
            {
                list.Add(i.ToString());
            }
        }

        //2. 캐릭터로 변환하는건 길이기 때문에 20만 곱하기 * 7이 최대, 그러면 시간 안에 가능
        List<int> result = new List<int>();
        foreach(var item in list)
        {
            bool isResult = true;
            foreach(var c in item)
            {
                if(c == '0' || c == '5')
                {

                }
                else
                {
                    isResult = false;
                    break;
                }
            }

            if (isResult)
            {
                result.Add(int.Parse(item));
            }
        }

        if(result.Count == 0)
        {
            int[] numbers = { -1 };
            return numbers;
        }
        else
        {
            return result.ToArray();
        }        
    }
}