using System;

namespace Main{
    class Program {
        static void Main(string[] args) {
            int[] arr = { 1, 2, 3, 4, 5 };
            int _target = -2;
            int p_1 = 0;
            int p_2 = arr.Length - 1;

            RecursiveFunction(arr, _target, p_1, p_2);
        }
        static void RecursiveFunction(int[] nums, int target, int p1, int p2){
            if(nums[p1] + nums[p2] == target || nums[p1] - nums[p2] == target){
                Console.WriteLine("Found: " + nums[p1] + "(" + p1 + ")" + " " + nums[p2] + "(" + p2 + ")");
                return;
            }
            
            if(p1 < p2){
                if (nums[p1] + nums[p2] > target)
                {
                    RecursiveFunction(nums, target, p1, p2 - 1);
                }
                else { 
                    RecursiveFunction(nums, target, p1 + 1, p2);
                }
            }
            else{
                Console.WriteLine("Not Found");
            }
        }
    } 
}