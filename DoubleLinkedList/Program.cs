using System;
using static System.Console;

namespace Main{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] values = {5, 3, 1, 9, 4};

            LinkedList linkedList = new LinkedList();
            FillList(ref values, ref linkedList);
            linkedList.WalkList(linkedList);
        }

        static void FillList(ref int[] list, ref LinkedList passedList){
            for (int iter = 0; iter < list.Length; iter++) { 
                passedList.Insert(list[iter]);
            }
        }
    }

    class Node{
        public int value;
        public Node next;
        public Node last;

        public Node() { }
        public Node(int value) { 
            this.value = value;
            this.next = null;
            this.last = null;
             }
        public Node(int value, Node node){ 
            this.value = value;
            this.next = null;
            this.last = node;
             }
    }

    class LinkedList{
        public Node head = null;

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
            Node node = passedList.head;
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