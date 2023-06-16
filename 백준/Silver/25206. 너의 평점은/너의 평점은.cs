using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Sources;

public class Example
{
    public static void Main()
    {
        Solution solution = new Solution();

        decimal sum = 0.0m;
        decimal sumScore = 0.0m;
        for(int i = 0; i< 20; i++)
        {
            string[] line = Console.ReadLine().Split(' ');
            decimal score = Convert.ToDecimal(line[1]);
            decimal grade = solution.gradeToscore(line[2]);

            if (line[2] != "P")
            {
                sum += score * grade;
                sumScore += score;
            }
        }

        Console.WriteLine(sum / sumScore);
    }
}


public class Solution
{
    public decimal gradeToscore(string grade)
    {
        decimal answer = 0.0m;

        switch (grade)
        {
            case "A+":
                answer = 4.5m;
                break;
            case "A0":
                answer = 4.0m;
                break;
            case "B+":
                answer = 3.5m;
                break;
            case "B0":
                answer = 3.0m;
                break;
            case "C+":
                answer = 2.5m;
                break;
            case "C0":
                answer = 2.0m;
                break;
            case "D+":
                answer = 1.5m;
                break;
            case "D0":
                answer = 1.0m;
                break;
            case "F":
                answer = 0.0m;
                break;           
        }

        return answer;
    }
}