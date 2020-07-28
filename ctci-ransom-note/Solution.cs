class Solution {

    // Complete the checkMagazine function below.
    static void checkMagazine(string[] magazine, string[] note) {
        Dictionary<string, int> map = new Dictionary<string, int>();
        int j = 0;
        bool flag = true;

        for (int i = 0; i < magazine.Length; i++){
            if( !map.ContainsKey(magazine[i]) )
                map.Add(magazine[i], 1);
            else
                map[magazine[i]] += 1;
        }

        while ( flag && j < note.Length ){
            if( ! map.ContainsKey(note[j]) || map[note[j]] == 0 )
                flag = false;
            else
                map[note[j]] -= 1;
            j++;
        }

        if( flag )
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");            
    }
}
