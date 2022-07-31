public class Solution {
    public int FindJudge(int n, int[][] trust) {
        if(trust is null || trust.Length < (n -1)) 
           return -1;
        
        var people = new int[n+1];
        for(int i = 0; i < trust.Length; i++)
        {
            people[trust[i][0]]--;
            people[trust[i][1]]++;
        }
        for(int i = 1; i < people.Length; i++)
            if(people[i] == n-1) return i;
    
        return -1;        
   }
}
