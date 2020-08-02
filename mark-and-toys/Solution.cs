class Solution {

    // Complete the maximumToys function below.
    static int maximumToys(int[] prices, int k) {
        int count = 0, sum = 0;
        bool flag = true;
        Array.Sort(prices);
        while(count < prices.Length && flag ){
            if (sum > k)
                flag = false;
            else{
                sum += prices[count++];
            }
        }
        return count - 1;
    }
}
