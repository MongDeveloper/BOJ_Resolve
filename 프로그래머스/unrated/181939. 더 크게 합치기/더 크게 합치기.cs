using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        
        int result1 = int.Parse($"{a}{b}");
        int result2 = int.Parse($"{b}{a}");
        
        answer = result1 > result2 ? result1 : result2;
        
        return answer;
    }
}