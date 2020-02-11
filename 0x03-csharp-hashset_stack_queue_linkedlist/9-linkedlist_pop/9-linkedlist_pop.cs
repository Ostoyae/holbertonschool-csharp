using System;
using System.Collections.Generic;

class LList {
    public static int Pop(LinkedList<int> myLList) {
        int head = 0;
        if (myLList.Count == 0)
            return head;

        head = myLList.First.Value;
        myLList.RemoveFirst();
        return head;
    }
}