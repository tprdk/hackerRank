// O(n)

class Solution {

    // Complete the freqQuery function below.
    static List<int> freqQuery(List<List<int>> queries) {
        Dictionary<int, int> map = new Dictionary<int, int>();        // element : frequency
        Dictionary<int, List<int>> frequencyMap = new Dictionary<int, List<int>>();   //// frequency : elements
        List<int> list = new List<int>();    // return list   
        int element, command;
        for (int i = 0 ; i < queries.Count; i++){           
            command = queries.ElementAt(i).ElementAt(0);
            element = queries.ElementAt(i).ElementAt(1);
            if ( command == 1){
                if ( !map.ContainsKey(element)){    // does map contains this element
                    map.Add(element, 1);
                    if( !frequencyMap.ContainsKey(1))       // does frequecy map contains this the frequency 1 ?
                        frequencyMap.Add(1, new List<int>(){element});   
                    else
                        frequencyMap[1].Add(element);       
                }
                else{   // eleman var
                    map[element]++;             // add 1 to element's frequency
                    if ( !frequencyMap.ContainsKey(map[element]) )  //does frequecy map contains new frequency
                        frequencyMap.Add(map[element], new List<int>(){element});   
                    else
                        frequencyMap[map[element]].Add(element);    
                    frequencyMap[map[element] - 1].Remove(element);  // remove element from the old list
                }
            }
            else if ( command == 2){
                if ( map.ContainsKey(element) ){  // does map contains the element that we want the delete
                    if (map[element] == 1){
                        frequencyMap[map[element]].Remove(element);
                        map.Remove(element);        // we delete it 
                    }else{
                        map[element]--; // decrease the frequency count
                        frequencyMap[map[element] + 1].Remove(element); // delete from frequency map
                        if ( !frequencyMap.ContainsKey(map[element]) )  // does frequecy map contains new frequency
                            frequencyMap.Add(map[element], new List<int>(){element});    //no
                        else
                            frequencyMap[map[element]].Add(element);     //yes
                    }
                }
            }
            else{
                if ( frequencyMap.ContainsKey(element) && frequencyMap[element].Count > 0 )
                    list.Add(1);
                else
                    list.Add(0);
            }
        }

        return list;
    }
}
