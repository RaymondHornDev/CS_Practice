using System;

namespace Main{
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