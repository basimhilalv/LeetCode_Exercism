public class Solution {
    public string LongestPalindrome(string s) {
        int strlen = 0;
        string u = "";
        for(int i = 0; i<s.Length;i++){
            for(int j = 1; j<=s.Length-i;j++)
            {
                string t = s.Substring(i,j);
                if(isPalindrome(t)){
                    if(strlen < t.Length){
                        strlen = t.Length;
                        u = t;
                    }
                }
            }
        }
        return u;
    }
    public bool isPalindrome(string s){
        string temp = "";
        for(int i = s.Length-1;i>=0;i--){
            temp += s[i];
        }
        if(temp == s) return true;
        else return false;
    }
}