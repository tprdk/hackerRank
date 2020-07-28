class Solution {

    // Complete the arrayManipulation function below.
    static long arrayManipulation(int n, int[][] queries) {
        long max = 0, sum = 0, value;
        int firstIndex, lastIndex;
        long[] array = new long[n + 1];

        for ( int i = 0; i < queries.Length; i++){  // we loop all rows
            firstIndex = queries[i][0];
            lastIndex = queries[i][1];
            value = (long) queries[i][2];
            array[firstIndex] += value; // add value to first index array
            if(lastIndex + 1 <= n)  // if (last index + 1) in the array
                array[lastIndex + 1] -= value;  // we substract value from its value this is end point of adding task for this row
        }

        for ( int i = 0; i < n + 1; i++){   
            sum = sum + array[i];
            if(sum > max)
                max = sum;
        }
        return max;
    }
}
