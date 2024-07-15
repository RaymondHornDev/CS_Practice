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
            if(deque.HasNodes == true)
            {
                WriteLine(deque.Pop().value);
                RecursiveEmpty(deque);
            }
        }
    }
}