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
}