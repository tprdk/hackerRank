static string twoStrings(string s1, string s2) {
        Dictionary<char, int> map = new Dictionary<char, int>();
        int j = 0;
        bool flag = true;

        for( int i = 0; i < s1.Length ; i++){
            if( !map.ContainsKey(s1[i]) )
                map.Add(s1[i], 0);
        }

        while ( flag && j < s2.Length ){
            if( map.ContainsKey(s2[j]) )
                flag = false;
            else
                j++;
        }

        if( !flag )
            return "YES";
        return "NO";
    }
}
