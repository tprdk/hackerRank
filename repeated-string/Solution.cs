class Solution {

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n) {
        int modeCount = 0;
        long  count = 0, mode = n % s.Length;

        for ( int i = 0 ; i < s.Length ; i++){
            if ( s[i] == 'a' ){
                if( i < mode )
                    modeCount++;
                count ++ ;
            }   
        }

        if( n % s.Length == 0 )
            return (n / s.Length) * count; 
        return (n / s.Length) * count + modeCount;
    }
}
