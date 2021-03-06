using System;
using System.Collections.Generic;

class LList {
    public static LinkedListNode<int> Insert (LinkedList<int> myLList, int n) {

        LinkedListNode<int> curNode;
        LinkedListNode<int> node = new LinkedListNode<int> (n);

        if (myLList.Count > 0) {
            for (curNode = myLList.First; curNode.Next != null; curNode = curNode.Next)
                if (curNode.Value > n)
                    break;

            if (curNode.Next == null && curNode.Value < n)
                myLList.AddLast (node);
            else if (curNode.Previous == null)
                myLList.AddFirst(node);
            else
                myLList.AddAfter (curNode.Previous, node);
        } else
            myLList.AddFirst (node);

        return node;
    }
}