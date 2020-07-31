// O(N)
class Solution {

    // Complete the isValid function below.
    static string isValid(string s) {
        Dictionary<char, int> map = new Dictionary<char, int>();
        bool flag = true, oneRemove = false;
        int count = -1;

        for ( int i = 0; i < s.Length; i++){
            if ( !map.ContainsKey(s[i]))
                map.Add(s[i], 0);
            else
                map[s[i]]++;
        }

        foreach ( var item in map ){
            if ( count < 0 )
                count = item.Value;
            else if ( count != item.Value ){
                if ( !oneRemove )
                    oneRemove = true;
                else{
                    flag = false;
                    break;
                }
            }
        }
        if (flag)
            return "YES";
        return "NO";
    }
}
