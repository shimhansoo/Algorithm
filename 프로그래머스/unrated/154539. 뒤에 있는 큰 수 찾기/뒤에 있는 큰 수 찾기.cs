using System;
using System.Linq; 
using System.Collections.Generic; 

public class Solution {
    public int[] solution(int[] numbers) {
        string[] answer = new string[numbers.Length];
        
        
        for(int i = 0; i < answer.Length; i++) {
            answer[i] = "-1";
        }
        
        Stack<int> stack = new Stack<int>();
        
        for(int i = 0; i < numbers.Length; i++) {
            while(stack.Count > 0) {
                // 자신보다 뒤에 있는 숫자중에서 자신보다 크면서 가장 가까이 있는 수를 찾는 과정
                if(numbers[stack.Peek()] < numbers[i]) {
                    answer[stack.Peek()] = numbers[i].ToString();
                    stack.Pop(); // 조건을 달성하였으므로 해당 index는 제거
                } else {
                    break;
                }
            }
            stack.Push(i); // while 안에 if 조건에 해당이 안 될 경우 index가 누적되는 형식
        }
        
        int[] result = new int[answer.Length];
        for(int i = 0; i < result.Length; i++) {
            result[i] = int.Parse(answer[i]);
        }
        
        return result;
    }
}