using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[num_list.Length +1];
        
        for(int i=0;i<num_list.Length;i++)
        {
            answer[i] = num_list[i];
        }
        
        int result = num_list[num_list.Length - 1] - num_list[num_list.Length - 2];
                
        if(result > 0)
            answer[num_list.Length] = result;
        if(result <= 0)
            answer[num_list.Length] = num_list[num_list.Length - 1] * 2;
        
            
        return answer;
    }
}