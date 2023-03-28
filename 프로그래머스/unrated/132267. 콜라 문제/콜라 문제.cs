using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int total = 0;
        int leftover_cola = n;
        int change = 0;
        int left = 0;
        
        while(leftover_cola >= a)
        {
            change = leftover_cola / a; // 교환한 병의 개수
            left = leftover_cola % a; // 교환하고 남은 병
            leftover_cola = (change * b); //  남은 병은 교환한 병 + 교환하지 못한 병
            leftover_cola += left;
            total += change * b; // 저장
            
            change = 0; left = 0; // 변수 초기화
            
        }
        return total;
    }
}