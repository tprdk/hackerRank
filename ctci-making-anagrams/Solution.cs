// O(N)
class Solution {

    // Complete the makeAnagram function below.
    static int makeAnagram(string a, string b) {
        Dictionary<char, int> map = new Dictionary<char, int>();
        int count = 0;

        for (int i = 0; i < a.Length ; i++){
            if ( map.ContainsKey(a[i]) )
                map[a[i]]++;
            else
                map.Add(a[i], 1);
        }

        for (int j = 0; j < b.Length ; j++){
            if ( !map.ContainsKey(b[j]) )
                count++;
            else
                map[b[j]]--; 
        }

        foreach ( var item in map){
            if( item.Value != 0 )
                count += Math.Abs(item.Value);
        }

        return count;
    }
}
