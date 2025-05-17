public class Solution {
    public string LongestPalindrome(string s) {
        if(s == null || s.Length == 0)
        {
            return "";
        }
        int start = 0;
        int end = 0;
        for(int i =0; i<s.Length; i++){
            int odd = expand(s,i,i);
            int even = expand(s,i,i+1);
            int max_len = Math.Max(odd, even);
            if(max_len > end-start){
                start = i - (max_len - 1) /2;
                end = i + max_len / 2;
            }
        }
        return s.Substring(start, end - start + 1);
    }
    private int expand(string s, int left, int right){
        while(left>=0 && right<s.Length && s[left] == s[right]){
            left--;
            right++;
        }
        return right - left -1;
    }
}