using System;

namespace Main{
    class Tree{
        public Node? root;

        public void Insert(int value){
            if(root != null){
                Node? current = root;
                RecursiveAdd(value, current);
            }
            else{
                root = new Node(value);
            }
        }

        void RecursiveAdd(int passedValue, Node passedNode){
            if (passedValue < passedNode.value)
            {
                if (passedNode.left != null)
                {
                    RecursiveAdd(passedValue, passedNode.left);
                }
                else
                {
                    passedNode.left = new Node(passedValue);
                }
            }
            else if (passedValue > passedNode.value)
            { 
                if(passedNode.right != null)
                {
                    RecursiveAdd(passedValue, passedNode.right);
                }
                else
                {
                    passedNode.right = new Node(passedValue);
                }
            }
        }

        public void FillTree(int[] nums, int value){
            if( value < nums.Length){
                Insert(nums[value]);
                FillTree(nums, value + 1);
            }
        }

        public void InOrder(Node passedNode){
            if (passedNode.left != null){
                InOrder(passedNode.left);
            }

            Console.WriteLine(passedNode.value);

            if (passedNode.right != null) { 
                InOrder(passedNode.right);
            }
        }
    }
}