using System;

public class Solution
{
    public int solution(string ineq, string eq, int n, int m)
    {
        int answer = 0;

        string compare = $"{ineq}{eq}";

        switch (compare)
        {
            case ">=":
                answer = n >= m ? 1 : 0;
                break;
            case "<=":
                answer = n <= m ? 1 : 0;
                break;
            case ">!":
                answer = n > m ? 1 : 0;
                break;
            case "<!":
                answer = n < m ? 1 : 0;
                break;
            default:
                break;
        }

        return answer;        
    }
}