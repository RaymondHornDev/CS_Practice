using System;

namespace Main{
    class Program {
        public static void Main(string[] args) {
            int[] arr = { 3, 5, 2, 9, 6, 1 };
            Tree tree = new Tree();

            tree.FillTree(arr, 0);

            tree.InOrder(tree.root);

        }
    }
}