using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
                
        answer = solution2(n, n % 2);
                
        return answer;
    }
    
    public int solution2(int n, int isType)
    {
        int answer = 0;
        
        if(isType == 0) //짝수이면
        {
            for(int i = 0; i<= n; i = i + 2)
            {
                answer += i * i;
            }
        }
        else
        {
            for(int i = 1; i<= n; i = i + 2)
            {
                answer += i;
            }            
        }
        
        return answer;
    }
}