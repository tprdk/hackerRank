class Solution {
    // Complete the minimumSwaps function below.
    static int minimumSwaps(int[] arr) {
        int swap = 0, i = 0, temp, tempIndex;
        bool swapFlag;

        while( i < arr.Length ){
            if ( arr[i] != i + 1){    // Swap element if it is at the wrong index
                tempIndex = arr[i] - 1;
                temp = arr[i];
                arr[i] = arr[tempIndex];
                arr[tempIndex] = temp;
                swap++;
                i = Math.Min(i, tempIndex);  //Set i to min value because maybe we change early index
            }
            else
                i++;
        }
        
        return swap;
    }
}
