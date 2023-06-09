using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int a, int b, int c, int d)
    {
        int answer = 0;

        int[] arr = { a, b, c, d };
        
        Dictionary<int, int> dic = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (dic.ContainsKey(arr[i]))
            {
                dic[arr[i]]++;                
            }
            else
            {
                dic.Add(arr[i], 1);
            }
        }

        int p = 0;
        int q = 0;
        int r = 0;

        //p,q,r 판정

        //4
        if (dic.Count == 1)
        {
            p = dic.Keys.First();
            answer = 1111 * p;
        }

        //2 1 1 
        if (dic.Keys.Count == 3)
        {            
            foreach (KeyValuePair<int, int> pair in dic)
            {
                if(pair.Value == 2)
                {
                    p = pair.Key;
                }
                else if(q == 0)
                {
                    q = pair.Key;
                }
                else if(r == 0)
                {
                    r = pair.Key;
                }

            }
            answer = q * r;
        }

        //3 1
        if(dic.Keys.Count == 2 && dic.Values.Max() == 3) 
        { 
            foreach(KeyValuePair<int, int> pair in dic) 
            {
                if(pair.Value == 3)
                {
                    p = pair.Key;
                }
                else if(pair.Value == 1)
                {
                    q = pair.Key;
                }
            }

            answer = (int)Math.Pow(10 * p + q, 2);
        }

        //2 2
        if (dic.Keys.Count == 2 && dic.Values.Max() == 2)
        {
            foreach (KeyValuePair<int, int> pair in dic)
            {
                if(p == 0)
                {
                    p = pair.Key;
                }
                else if(q == 0)
                {
                    q = pair.Key;
                }                
            }

            answer = (p + q) * Math.Abs(p - q);
        }
        //1 1 1 1 
        if (dic.Keys.Count == 4) 
        {
            p = dic.Keys.Min();
            answer = p;
        }
  
        return answer;
    }
}