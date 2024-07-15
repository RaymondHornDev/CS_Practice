using System;

namespace Main{
    class Node{
        public int value;
        public Node? next;
        public Node? last;

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
}