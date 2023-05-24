using System;

public class Solution
{
    public int[] solution(int[] arr, int[,] queries)
    {
        int[] answer = new int[arr.Length];

        for (int i = 0; i < queries.GetLength(0); i++)
        {
            int temp = arr[queries[i, queries.GetLength(1) - 2]];
            arr[queries[i, queries.GetLength(1) - 2]] = arr[queries[i, queries.GetLength(1) - 1]];
            arr[queries[i, queries.GetLength(1) - 1]] = temp;
        }

        Array.Copy(arr, answer, answer.Length);

        return answer;
    }
}