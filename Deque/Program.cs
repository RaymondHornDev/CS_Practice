using System;
using static System.Console;

namespace Main
{
    public class Program
    {
        static void Main(string[] args) {
            Deque dq = new Deque();
            int[] myArray = { 4, 2, 3, 5, 8, 6, 7 };

            Program.RecursiveFill(myArray, 0, dq);
            Program.RecursiveEmpty(dq);
        }

        static void RecursiveFill(int[] list, int value, Deque deque)
        {
            if(value < list.Length)
            {
                deque.Push(list[value]);
                RecursiveFill(list, value + 1, deque);
            }
        }

        static void RecursiveEmpty(Deque deque){
            if(deque.HasNodes == true){
                WriteLine(deque.Pop().value);
                RecursiveEmpty(deque);
            }
        }
    }

    class Node
    {
        public int value;
        public Node next = null;
        public Node prev = null;

        public Node() { }
        public Node(int value)
        {
             this.value = value;
        }
    }

    class Deque
    {
        public bool HasNodes = false;
        Node head = null;
        Node tail = null;

        public void Push(int value)
        {
            Node n = new Node(value);
            Node localHead = head;

            if (head == null)
            {
                tail = n;
                head = n;
                HasNodes = true;
            }
            else
            {
                n.next = head;
                head.prev = n;
                head = n;
            }
        }

         public Node Pop()
         {
            Node return_node = tail;
            tail = return_node.prev;
            return_node.prev = null;
            tail.next = null;
            if(tail == null){
                HasNodes = false;
            }
            return return_node;
        }
    }
}