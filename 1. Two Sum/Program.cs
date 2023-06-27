using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _1.Two_Sum
{
    internal class Program
    {

        /* 
        Given an array of integers nums and an integer target, 
        return indices of the two numbers such that they add up to target.
        You may assume that each input would have exactly one solution, 
        and you may not use the same element twice.

        You can return the answer in any order. 


        Constraints:

        2 <= nums.length <= 104
        -109 <= nums[i] <= 109
        -109 <= target <= 109
        Only one valid answer exists.
        */

        static void Main(string[] args)
        {
            int[] ints = { 2, 7, 11, 15 };
            int t = 9;
            Console.WriteLine(string.Join(" ", TwoSum(ints, t)));
            Console.ReadKey();

            int[] TwoSum(int[] nums, int target)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        int tmp = nums[i] + nums[j];

                        if (tmp == target && i != j)
                            return new int[] { i, j };
                    }
                }

                return null;
            }
        }
    }
}
