using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        
        string even = "";
        string odd = "";
        
        foreach(var item in num_list)
        {
            if(item % 2 == 0)
                even = $"{even}{item}";
            else
                odd = $"{odd}{item}";
        }
        
        answer = int.Parse(even) + int.Parse(odd);
        
        return answer;
    }
}