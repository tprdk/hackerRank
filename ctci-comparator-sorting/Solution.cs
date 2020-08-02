public int compare(Player a, Player b) {
        int flag = 0, i = 0, max;
        if ( a.score > b.score )
            return -1;
        else if ( a.score < b.score )
            return 1;
        else{
            if ( a.name.length() <= b.name.length() )
                max = a.name.length();
            else
                max = b.name.length();
            while ( i < max ){
                if ( a.name.charAt(i) - 'a' < b.name.charAt(i) - 'a')
                    return -1;
                else if (a.name.charAt(i) - 'a' > b.name.charAt(i) - 'a')
                    return 1;
                else
                    i++;
            }
            if ( b.name.length() == a.name.length() )
                return 0;
            else if (a.name.length() < b.name.length())
                return -1;
            else
                return 1;
        }
    }
}
