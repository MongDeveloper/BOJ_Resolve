using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] arr, int[,] queries)
    {        
        int[] answer = new int[queries.GetLength(0)];

        for (int i = 0; i < queries.GetLength(0); i++)
        {
            int s = queries[i, 0];
            int e = queries[i, 1];
            int k = queries[i, 2];

            List<int> list = new List<int>();            
            for (int j = s; j <= e; j++)
            {
                if (arr[j] > k)
                {
                    list.Add(arr[j]);                    
                }
            }

            if (list.Count > 0)
                answer[i] = list.Min();
            else
                answer[i] = -1;

        }

        return answer;
    }
}