
class Solution {

    // Complete the rotLeft function below.
    static int[] rotLeft(int[] a, int d) {  

        int[] result = new int[a.Length];
        d = d % a.Length;

        for (int i = 0 ; i < a.Length ; i++){
            if ( i - d < 0 )
                result[i - d + a.Length] = a[i];
            else
                result[i - d] = a[i];    
        }
        
        return result;
    }
}    
