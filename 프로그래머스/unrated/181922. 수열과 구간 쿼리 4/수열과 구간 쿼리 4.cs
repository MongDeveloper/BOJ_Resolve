using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr, int[,] queries)
    {        
        int[] answer = new int[arr.Length];

        for (int i = 0; i < queries.GetLength(0); i++)
        {
            int s = queries[i, 0];
            int e = queries[i, 1];
            int k = queries[i, 2];

            List<int> list = new List<int>();
            for (int j = 0; j < arr.Length; j++)
            {
                if(j >= s && j <= e && j % k == 0)                
                {
                    arr[j]++;
                }
            }
        }

        Array.Copy(arr, answer, arr.Length);

        return answer;
    }
}