class Solution {

    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int[] c) {
        
        int minStep = 0, i = 0;

        while( i != c.Length - 1 ){
            if( i + 2 < c.Length && c[i + 2] == 0 )
                i++;
            i++;
            minStep++;    
        }

        return minStep;
    }
}    
