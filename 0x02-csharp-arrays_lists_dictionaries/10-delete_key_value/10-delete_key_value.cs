using System.Collections.Generic;

class Dictionary {
    public static Dictionary<string, string> 
    DeleteKeyValue(Dictionary<string, string> myDict, string key) {
        if (myDict.ContainsKey(key))
            myDict.Remove(key);
        return myDict;
    }
}