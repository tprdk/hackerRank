//O(N)
class Solution {

    // Complete the alternatingCharacters function below.
    static int alternatingCharacters(string s) {
        int i = 0, count = 0 ;
        while ( i < s.Length - 1 ){
            if ( s[i] == s[i + 1] )
                count++;
            i++;
        }
        return count;
    }
}
