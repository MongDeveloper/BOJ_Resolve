using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr)
    {        
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if(stack.Count == 0)
            {
                stack.Push(arr[i]);
            }
            else if(stack.Peek() < arr[i])
            {
                stack.Push(arr[i]);
            }
            else if(stack.Peek() >= arr[i])
            {
                stack.Pop();
                i = i - 1;
            }
        }

        int[] stk = new int[stack.Count];

        for(int i = stack.Count - 1; i >= 0; i--)
        {
            stk[i] = stack.Pop();
        }

        return stk;
    }
}