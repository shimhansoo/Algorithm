public class Solution {
    public int solution(int n) {
        int answer = 0;
        int fist = 0;
        int second = 1;
        
        for(int i=2; i<=n; i++)
        {
            answer = (fist+second)%1234567;
            fist = second %1234567 ;
            second = answer ;
        }
        answer = answer;
        
        return answer;
    }
}