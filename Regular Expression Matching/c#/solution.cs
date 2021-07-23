public class Solution {
    public bool IsMatch(string s, string p) {
        if (string.IsNullOrEmpty(p)) {
            return string.IsNullOrEmpty(s);
        }
        
        bool first_match = (!string.IsNullOrEmpty(s) &&
                            (p[0] == s[0] || p[0] == '.'));
        
        if (p.Length >= 2 && p[1] == '*') {
            return (IsMatch(s, p.Substring(2)) || (first_match && IsMatch(s.Substring(1), p)));
        } else {
            return first_match && IsMatch(s.Substring(1), p.Substring(1));
        }
    }
}