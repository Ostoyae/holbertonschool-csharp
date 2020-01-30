using System.Collections.Generic;

class Dictionary {
    public static string BestScore(Dictionary<string, int> myList){
        string best = "martin";
        int score = 0;

        foreach((string k, int v) in myList){
            if (v > score)
                (best, score) = (k,v);
        }

        return best;
    }
}