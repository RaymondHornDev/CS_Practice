using System;
using Linq;

namespace Main{
    public class Program
    {
        public static void Main(string[] args)
        {

        }
    }

    class Node{
        public int value;
        public Node next;
        public Node last;

        public Node() { };
        public Node(int value) { 
            this.value = value;
             }
        public Node(int value, Node node){ 
            this.value = value;
            this.last = node;
             }
    }

    class LinkedList{
        public Node head;

        public void Insert(int value){
            if(head){
                RecursiveAdd(head, value)
            }
            else{
                head = new Node(value);
            }
        }

        void RecursiveAdd(Node node, int value){
            if (node.next) { 
                RecursiveAdd(node.next, value);
            }
            else{
                node.next = new Node(value, this);
            }
        }
    }
}


