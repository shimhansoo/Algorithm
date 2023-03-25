using System;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        
        string Left = "";
        string Right = "";
        
        for(int i = 1; i < food.Length; i++)
        {
            for(int j = 0; j < food[i] / 2; j++)
            {
                Left += i.ToString();
            }
        }
        
        for(int i = food.Length - 1; i > 0; i--)
        {
            for(int j = 0; j < food[i] / 2; j++)
            {
                Right += i.ToString();
            }
        }
        
        answer =  Left  + "0" + Right;
        return answer;
    }
}