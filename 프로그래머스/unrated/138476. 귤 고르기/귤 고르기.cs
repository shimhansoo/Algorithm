using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int k, int[] tangerine) {
        int answer = 0;
        Dictionary<int, int> a = new Dictionary<int, int>();
        foreach (int i in tangerine) {
            if (a.ContainsKey(i)) {
                a[i]++;
            } else {
                a.Add(i, 1);
            }
        }
        var sorted_a = a.OrderByDescending(x => x.Value);
        foreach (var item in sorted_a) {
            if (k <= 0) {
                return answer;
            }
            k -= item.Value;
            answer++;
        }
        return answer;
    }
}
