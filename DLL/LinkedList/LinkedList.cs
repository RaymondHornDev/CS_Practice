using System;
using static System.Console;

namespace Main{
    class LinkedList{
        public Node? head = null;


        public void Insert(int value){
            if(head != null){
                RecursiveAdd(head, value);
            }
            else{
                head = new Node(value);
            }
        }

        void RecursiveAdd(Node node, int value){
            if (node.next != null) { 
                RecursiveAdd(node.next, value);
            }
            else{
                node.next = new Node(value, node);
            }
        }

        public void WalkList(LinkedList passedList){
            Node? node = passedList.head;
            RecursiveWalk(node);
        }

        void RecursiveWalk(Node passedNode){
            WriteLine(passedNode.value);
            if (passedNode.next != null) { 
                RecursiveWalk(passedNode.next);
            }
        }
    }
}